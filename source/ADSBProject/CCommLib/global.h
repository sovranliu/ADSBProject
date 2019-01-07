//
//  global.h
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/3.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef global_h
#define global_h

#include <stdbool.h>
#define PI 3.1415926535
#define  e	(1/298.257223563)
#define  ALPHA	6378137

//DFmessage 最大接收范围，数值待定
#define restrict_distance 90000

#define LONGX long long

typedef unsigned char BYTE;

typedef enum {
    DF17 = 1,
    DF18,
    CAT021
} MessageType;

typedef struct {
    int sModeAddress;
    char flightNo[9];
    double latitude;
    double longtitude;
    double elapsedTime; //从当日零时起，所消耗的时间，单位秒
    double geometricAltitude; //几何高度
    double barometricAltitude; //气压高度
    double airSpeed; //空速
    BYTE airSpeedUnit; //空速单位
    double aircraftAngle; //飞行器航向
    double groundSpeed; //地速
    BYTE emitterCategory; //飞行器类型
} Cat021Data,*PCat021Data;

typedef enum {
    EC_UNKNOWN = 1, //未知类型
    LIGHT_AIRCRAFT = 2, //轻型飞机
    MEDIUM_AIRCRAFT = 3, //中型飞机
    ROTOCRAFT = 4, // 旋翼飞机
    GLIDER = 5, //滑翔机
    LIGHT_THAN_AIR = 6, //超轻型飞机
    PARACHUTIST = 7, //跳伞
//    HEAVY_AIRCRAFT = 5, //重型飞机
    ULM_LIGHT = 8, //UML轻型飞机
    UNMANNED_AERIAL_VEHICLE = 9, //无人机
    
} EmitterCategory;

typedef struct {
    double lat;
    double lon;
BYTE valid;
} LatLong;

typedef enum {
    IAS, //仪表空速
    MACH //马赫
} AirSpeedMode;

#ifdef __cplusplus
extern "C" {
#endif
	//本地参考经纬度
	extern LatLong ref_latLon;
#ifdef __cplusplus
};
#endif


//
//本地gps经纬度
static LatLong gps_latLon;

#endif /* global_h */
