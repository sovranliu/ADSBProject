//
//  msg_decode.cpp
//  adsbDecoder
//
//  Created by YangHongbing on 18/3/1.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include <stdio.h>
#include <map>
#include "global.h"
#include "message_type.h"
#include "DFMessagePreDecode.h"
#include "DFMessageDecode.h"
#include "cat021Decode.h"
#include "cat021Decode_v21.h"

static std::map<int, DFMessage> dfMessageMap;

static BYTE cat021Version = 0;

static int callBackObjectId;
static int callBackFunId;


/**
 * app启动时调用
 */
void init() {
    dfMessageMap.clear();
    ref_latLon.valid = 0;
}

/**
 * 注册回调方法，调用decodeMessage之后并不一定立即返回解析结果，需要通过此监听接收
 * @param listener
 */
void  registerListener(int objId, int funId) {
    callBackObjectId = objId;
    callBackFunId = funId;
	
}


/**
 * app销毁时调用
 */
void destroy() {
    dfMessageMap.clear();
    //删除回调方法
    callBackFunId = -1;
    callBackObjectId = -1;
}

/**
 * Cat021版本号
 * @param version
 * 0: v0.26
 * 1: v2.1
 */
void setCat021Version(BYTE version) {
    cat021Version = version;
}

////设置参考经纬度
//void setReferenceLatLong(double latititude, double longtitude) {
//    ref_latLon.valid = 1;
//    ref_latLon.lat = latititude;
//    ref_latLon.lon = longtitude;
//}

/**
 * 定位后的经纬度传入JNI
 * @param latitude
 * @param longtitude
 */
void setGPSLatLong(double latitude, double longtitude) {
    gps_latLon.valid = 1;
    gps_latLon.lat = latitude;
    gps_latLon.lon = longtitude;
}

/**
 * 解码主入口
 * @param message 原始二进制数据
 * @return true表示可以解析这条信息，false为不能解析
 * (cat021, DF17, DF18消息类型返回true, 其他false)
 */
extern "C" _declspec(dllexport) bool decodeMessage(BYTE message[]) {
    BYTE messageType = getMessageType(message);
    if (messageType == CAT021)
	{
        Cat021Data cat021Data;
        if (cat021Version == 1)
		{
            cat021Data = decodeCAT021V21(message);
        } else {
            cat021Data = *(decodeCAT021V026(message));
			//cat021Data = decodeCAT021V026(message);
        }
        //给上层回调结果
        return true;
    } 
	else if (messageType == DF17 || messageType == DF18)
	{
        int icao = getDFMessageICAO(message);
        DFMessage df;
        resetDFMessage(&df);
        std::map<int, DFMessage>::iterator it = dfMessageMap.find(icao);
        if (it != dfMessageMap.end()) {
            df = it->second;
        }
        time_t now = time(NULL);
        if (df.df == 0)
		{ //新的消息
            df.time = now;
        } 
		else
		{
            long messageValidPeriod;
            if (df.positionType == AIRBORNE_POSITION)
			{
                messageValidPeriod = AIRBONE_POSITION_VALID_PERIOD;
            }
			else
			{
                messageValidPeriod = SURFACE_POSITION_VALID_PERIOD;
            }
            //消息接收延迟大于阈值，丢弃
            if (now - df.time > messageValidPeriod)
			{
                dfMessageMap.erase(icao);
                resetDFMessage(&df);
            }
        }
        preDecodeDFMessage(message, &df);
        if (df.paired) {
            Cat021Data cat021 = decodeDFMessage(df);
            LONGX result = dfMessageMap.erase(icao);
            //给上层回调结果
        } else {
            //添加到列表中
            dfMessageMap[icao] = df;
        }
        return true;
    }
    return false;
}
