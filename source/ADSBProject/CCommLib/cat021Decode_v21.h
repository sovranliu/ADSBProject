//
//  cat021Decode_v21.h
//  adsbDecoder
//
//  Created by YangHongbing on 18/2/7.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef cat021Decode_v21_h
#define cat021Decode_v21_h

#define LATLON_UNIT (180 / pow(2, 23))
#define LATLON_UNIT_HIGH_RES (180 / pow(2, 30))
#define AIR_SPEED_UNIT_IAS (pow(2, -14)) //IAS速度单位，海里/秒
#define AIR_SPEED_UNIT_MACH (0.001) //马赫
#define TRUE_AIR_SPEED (1) //单位 节, knot
#define ALTITUDE_UNIT (6.25)  //高度单位
#define FLIGHT_LEVEL_UNIT (1.0/4) //气压高度单位
#define MAGNETIC_HEADING_UNIT (360 / pow(2, 16)) //单位 度

#include <stdio.h>


typedef enum {
    _DATA_SOURCE_IDENTIFICATION,  //2
    _TARGET_REPORT_DESCRIPTION, //1+
    _TRACKER_NUMBER, //2
    _SERVICE_IDENTIFICATION, //1
    _TIME_OF_APPLICABILITY_FOR_POSITION, //3
    _POSITION_IN_WGS_84_COORDINATES, //6
    _POSITION_IN_WGS_84_COORDINATES_HIGH_RES, //8
    _EXT_0,
    
    _TIME_OF_APPLICABILITY_FOR_VELOCITY, //3
    _AIRSPEED,  //2
    _TRUE_AIRSPEED,  //2
    _TARGET_ADDRESS, //3
    _TIME_OF_MESSAGE_RECEPTION_OF_POSITION, //3
    _TIME_OF_MESSAGE_RECEPTION_OF_POSITION_HIGH_PRECISION, //4
    _TIME_OF_MESSAGE_RECEPTION_OF_VELOCITY, //3
    _EXT_1,
    
    _TIME_OF_MESSAGE_RECEPTION_OF_VELOCITY_HIGH_PRECISION, //4
    _GEOMETRIC_HEIGHT, //2
    _QUALITY_INDICATORS, //1+
    _MOPS_VERSION, //1
    _MODE_3_A_CODE, //2
    _ROLL_ANGEL, //2
    _FLIGHT_LEVEL, //2
    _EXT_2,
    
    _MAGNETIC_HEADING, //2
    _TARGET_STATUS, //1
    _BAROMETRIC_VERTICAL_RATE, //2
    _GEOMETRIC_VERTICAL_RATE, //2
    _AIRBORNE_GROUND_VECTOR, //4
    _TRACK_ANGLE_RATE, //2
    _TIME_OF_REPORT_TRANSMISSION, //3
    _EXT_3,
    
    _TARGET_IDENTIFICATION, //6
    _EMITTOR_CATEGORY,  //1
    _MET_INFORMATION, //1+
    _SELECTED_ALTITUDE, //2
    _FINAL_STATTE_SELECTED_ALTITUDE, //2
    _TRAJECTORY_INTENT, //1+
    _SERVICE_MANAGEMENT, //1
    _EXT_4,
    
    _AIRCRAFT_OPERATIONAL_STATUS, //1
    _SURFACE_CAPABILITIES_AND_CHARACTERISTICS, //1+
    _MESSAGE_AMPLITUDE, //1
    _MODE_S_MB_DATA, //1+ N*8
    _ACAS_RESOLUTION_ADVISORY_REPORT, //7
    _RECEIVER_ID, //1
    _DATA_AGES, //1+
    _EXT_5
    
} CAT021_21_ITEM;

#ifdef __cplusplus
extern "C" {
#endif
    Cat021Data decodeCAT021V21(BYTE message[]);
#ifdef __cplusplus
};
#endif

#endif /* cat021Decode_v21_h */
