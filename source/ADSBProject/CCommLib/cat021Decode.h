//
//  cat021Decode.h
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/3.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef cat021Decode_h
#define cat021Decode_h

#define VERSION_0_26 = 0;
#define VERSION_21 = 1;

#define LATLON_UNIT (180 / pow(2, 25))  //经纬度单位
#define ALTITUDE_UNIT (6.25)  //高度单位
#define ANGLE_UNIT (0.01)  //角度单位
#define FLIGHT_LEVEL_UNIT (1.0/4) //气压高度单位
#define AIR_SPEED_UNIT_IAS (pow(2, -14)) //IAS速度单位，海里/秒
#define AIR_SPEED_UNIT_MACH (0.001) //马赫
#define TRUE_AIR_SPEED (1) //单位 节, knot
#define MAGNETIC_HEADING_UNIT (360 / pow(2, 16)) //单位 度
#define BAROMETRIC_VERTICAL_RATE_UNIT (6.25)  //单位 英尺/分钟

#include <stdio.h>
#include "global.h"

#endif /* cat021Decode_h */



typedef enum {
    DATA_SOURCE_IDENTIFICATION,
    TARGET_REPORT_DESCRIPTION,
    TIME_OF_DAY,
    POSITION_IN_WGS_84_COORDINATES,
    TARGET_ADDRESS,
    GEOMETRIC_ALTITUDE,
    FIGURE_OF_MERIT, //品质因素
    EXT_0,
    
    LINK_TECHNOLOGY, //链路技术标识，1字节
    ROLL_ANGLE,
    FLIGHT_LEVEL,
    AIR_SPEED,
    TRUE_AIRSPEED,
    MAGNOTIC_HEADING, //磁航向
    BAROMETRIC_VERTICAL_RATE,
    EXT_1,
    
    GEOMETRIC_VERTICAL_RATE,
    GROUND_VECTOR,
    RATE_OF_TURN,
    TARGET_IDENTIFICATION,
    VELOCITY_ACCURACY,
    TIME_OF_DAY_ACCURACY,
    TARGET_STATUS,
    EXT_2,
    
    EMITTOR_CATEGORY,
    MET_REPORT, //气象信息
    INTERMEDIATE_STATE_SELECTED_ALTITUDE, //中间态选定高度
    FINAL_STATUS_SELECTED_ALTITUDE, //末态选定高度
    TRAJECTORY_INTENT, //预定轨迹
    MODE_3A_CODE_IN_OCTAL_REPRESENTATION,
    SIGNAL_AMPLITUDE,
    EXT_3
    
} CAT021_0_26_ITEM;

void test();

#ifdef __cplusplus
extern "C" {
#endif
	_declspec(dllexport) Cat021Data* decodeCAT021V026(BYTE message[]);
#ifdef __cplusplus
};
#endif

