//
//  DFMessage.h
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/25.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef DFMessage_h
#define DFMessage_h

#include "global.h"
#include <time.h>

#define HEADING_UNIT (360 / pow (2, 10))

#define AIRBONE_POSITION_VALID_PERIOD (10 * 1000) //空中消息有效时间
#define SURFACE_POSITION_VALID_PERIOD (50 * 1000) //地面消息有效时间


typedef enum {
    TYPE_NULL,
    AircraftID_AND_TYPE,
    SURFACE_POSITION,
    AIRBORNE_POSITION,
    AIRBORNE_VELOCITY,
    TYPE_RESERVED //没有用到的类型都算在这里
} DFMessageType;

//一个配对的DF消息组合，至少包括下面几种消息
typedef struct {
    time_t time;
    BYTE df;
    int icao;
    bool paired; //是否配对标识，如果positionOdd和positionEven都有数据，置为true
    bool lastUpdateEven; //最近更新的消息是偶消息
    BYTE positionType; //空中消息还是地面消息
    BYTE positionOdd[8];
    BYTE positionEven[8];
    BYTE aircraftId[7];
    BYTE aircraftVelocity[7];
} DFMessage;

typedef struct {
    short altitudeBits;
    int latBits;
    int lonBits;
    BYTE timeBit;
    BYTE cprFormat;
} AirbonePosition;

typedef struct {
    BYTE headingStatus;
    BYTE heading;
    int latBits;
    int lonBits;
    BYTE timeBit;
    BYTE cprFormat;
} SurfacePosition;

typedef struct {
    BYTE code[6];
} AircraftId;

typedef struct {
    int type;
    int subType;
    BYTE meBits[6];
} AirboneVelocity;

#endif /* DFMessage_h */
