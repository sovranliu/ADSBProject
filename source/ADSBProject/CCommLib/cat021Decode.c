//
//  cat021Decode.c
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/3.
//  Copyright © 2018年 qiandian. All rights reserved.
//
#include "global.h"
#include <string.h>
#include <math.h>
#include <malloc.h>
#include <stdlib.h>
#include "cat021Decode.h"
#include "utils.h"
#include "message_type.h"


void decodeDataItem(CAT021_0_26_ITEM item, BYTE message[], int* index, Cat021Data* result);


void test() {
    printf("test method in cat021Decode\n");
    BYTE message[] = {0x15, 0x00, 0x31, 0xFF, 0xA3, 0xDB, 0x80, 0x42, 0x58, 0x00,
              0x28, 0x22, 0xEE, 0xE2, 0x00, 0x3F, 0x54, 0x2A, 0x01, 0x47,
              0x6A, 0xDF, 0x78, 0x0A, 0x9E, 0x08, 0xFC, 0x00, 0x07, 0x08,
              0x02, 0x21, 0xFF, 0x48, 0xFF, 0x48, 0x04, 0x24, 0x8C, 0x9C,
              0x0D, 0x22, 0xF6, 0xC3, 0x78, 0x20, 0x00, 0x02, 0x00};
    decodeCAT021V026(message);
    BYTE message2[] = {0x15, 0x00, 0x33, 0xFF, 0xA3, 0xDB, 0x84, 0x42, 0x58, 0x00,
               0x28, 0x22, 0xEE, 0xE2, 0x00, 0x40, 0xB2, 0xB6, 0x01, 0x44,
               0x46, 0x5E, 0x78, 0x10, 0x7C, 0x13, 0xD0, 0x40, 0x07, 0x08,
               0x04, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x06, 0xD2, 0xAB, 0x41,
               0x1C, 0x34, 0xB6, 0xD7, 0x6C, 0xA0, 0x02, 0x00, 0x03, 0x07,
               0x2F};
    
    decodeCAT021V026(message2);
}

 _declspec(dllexport) Cat021Data decodeCAT021V026(BYTE message[])
{
	 Cat021Data result;
    resetCat021Message(&result);
    int start = 0;
    int* dataIndex = &start; //数据指针，指到读取的位置
    BYTE byte0 = message[*dataIndex];
    if (byte0 == 21) {
        printf("\n\n这是一个CAT021信号\n");
    }
    *dataIndex = 1;
    BYTE lengthBytes[2];
    memcpy(lengthBytes, message + *dataIndex, sizeof(BYTE) * 2);
    *dataIndex += 2;
    int size = (lengthBytes[0] << 8) + lengthBytes[1];
    printf("信号长度为%d\n", size);
    int fspecCount = getFspecByteCount(message);
    BYTE *pFspec = (BYTE*)malloc(fspecCount * sizeof(BYTE));
    memcpy(pFspec, message + 3, fspecCount);
    *dataIndex += fspecCount;
    printf("fspec长度为%d\n", fspecCount);
    if (fspecCount > 0) {
        for (int i = 0; i < fspecCount; i++) {
            for (int bitIndex = 0; bitIndex < 7; bitIndex++) {
                BYTE fspecI = pFspec[i];
                fspecI = fspecI << bitIndex;
                fspecI = fspecI >> 7;
                if (fspecI != 0) {
                    CAT021_0_26_ITEM type = i * 8 + bitIndex;
                    decodeDataItem(type, message, dataIndex, &result);
                }
            }
            
        }
    }
    return result;
}

void decodeDataItem(CAT021_0_26_ITEM item, BYTE message[], int* index, Cat021Data* result) {
    switch (item) {
        case DATA_SOURCE_IDENTIFICATION: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            printf("sac code is %x\n", code[0]);
            printf("sic code is %x\n", code[1]);
            *index += 2;
            break;
        }
        case TARGET_REPORT_DESCRIPTION: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            printf("I021/040 data is %x, %x\n", code[0], code[1]);
            *index += 2;
            break;
        }
        case TIME_OF_DAY: {
            BYTE code[3];
            memcpy(code, message + *index, 3);
            printf("I021/030 data is %x, %x, %x\n", code[0], code[1], code[2]);
            double elapsedTime = byteArrayToInt(code, 3) * 1.0 / 128;
            printf("time of day value is %lf\n", elapsedTime);
            *index += 3;
            result -> elapsedTime = elapsedTime;
            break;
        }
        case POSITION_IN_WGS_84_COORDINATES: {
            BYTE code[8];
            memcpy(code, message + *index, 8);
            printf("I021/130 data is %x, %x, %x, %x, %x, %x, %x, %x\n", code[0], code[1], code[2], code[3], code[4], code[5], code[6], code[7]);
            *index += 8;
            BYTE latBytes[4], lonBytes[4];
            memcpy(latBytes, code, 4);
            memcpy(lonBytes, code + 4, 4);
            double lat = byteArrayToInt(latBytes, 4) * LATLON_UNIT;
            double lon = byteArrayToInt(lonBytes, 4) * LATLON_UNIT;
            printf("latitude is %lf, longtitude is %lf\n", lat, lon);
            result -> latitude = lat;
            result -> longtitude = lon;
            break;
        
        }
        case TARGET_ADDRESS: {
            BYTE code[3];
            memcpy(code, message + *index, 3);
            printf("I021/130 data is %x, %x, %x\n", code[0], code[1], code[2]);
            *index += 3;
            int address = byteArrayToInt(code, 3);
            result->sModeAddress = address;
            printf("target address is %d\n", address);
            break;
        }
        case GEOMETRIC_ALTITUDE: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            printf("I021/140 data is %x, %x\n", code[0], code[1]);
            *index += 2;
            double altitude = byteArrayToShort(code, 2) * ALTITUDE_UNIT;
            result -> geometricAltitude = altitude;
            printf("altitude is %lf\n", altitude);
            break;
        }
        case FIGURE_OF_MERIT: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            printf("I021/090 data is %x, %x\n", code[0], code[1]);
            *index += 2;
            break;
        }
        case LINK_TECHNOLOGY: {
            BYTE code = message[*index];
            *index += 1;
            printf("I021/210 data is %x\n", code);
            break;
        }
        case ROLL_ANGLE: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/230 data is %x, %x\n", code[0], code[1]);
            double angle = byteArrayToShort(code, 2) * ANGLE_UNIT;
            printf("roll angle is %lf\n", angle);
            break;
        }
        case FLIGHT_LEVEL: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/145 data is %x, %x\n", code[0], code[1]);
            double barometricHeight = byteArrayToShort(code, 2) * FLIGHT_LEVEL_UNIT;
            result -> barometricAltitude = barometricHeight;
            printf("barometric height is %lf\n", barometricHeight);
            break;
        }
        case AIR_SPEED: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/150 data is %x, %x\n", code[0], code[1]);
            BYTE byte0 = code[0];
            AirSpeedMode speedMode = byte0 >> 7;
            code[0] = code[0] & 0x7F; //去掉最高位
            double airSpeed;
            if (speedMode == MACH) {
                airSpeed = byteArrayToShort(code, 2) * AIR_SPEED_UNIT_MACH;
            } else {
                airSpeed = byteArrayToShort(code, 2) * AIR_SPEED_UNIT_IAS;
            }
            result -> airSpeed = airSpeed;
            result -> airSpeedUnit = speedMode;
            printf("airspeed mode = %d, airspeed is %lf\n", speedMode, airSpeed);
            break;
        }
        case TRUE_AIRSPEED: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/151 data is %x, %x\n", code[0], code[1]);
            double trueSpeed = byteArrayToShort(code, 2) * TRUE_AIR_SPEED;
            printf("true speed is %lf\n", trueSpeed);
            break;
        }
        case MAGNOTIC_HEADING: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/152 data is %x, %x\n", code[0], code[1]);
            double magneticHeading = byteArrayToShort(code, 2) * MAGNETIC_HEADING_UNIT;
            printf("magnetic heading is %lf\n", magneticHeading);
            break;
        }
        case BAROMETRIC_VERTICAL_RATE: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/155 data is %x, %x\n", code[0], code[1]);
            double barometricVerticalRate = byteArrayToShort(code, 2) * BAROMETRIC_VERTICAL_RATE_UNIT;
            printf("barometricVerticalRate is %lf\n", barometricVerticalRate);
            break;
        }
        case GEOMETRIC_VERTICAL_RATE: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/156 data is %x, %x\n", code[0], code[1]);
            double geometricVerticalRate = byteArrayToShort(code, 2) * BAROMETRIC_VERTICAL_RATE_UNIT;
            printf("geometricVerticalRate is %lf\n", geometricVerticalRate);
            break;
        }
        case GROUND_VECTOR: {
            BYTE speedBits[2], angleBits[2];
            memcpy(speedBits, message + *index, 2);
            *index += 2;
            memcpy(angleBits, message + *index, 2);
            *index += 2;
            printf("ground vector data is %x, %x, %x, %x\n", speedBits[0], speedBits[1], angleBits[0], angleBits[1]);
//            AirSpeedMode speedMode = speedBits[0] >> 7;
//            speedBits[0] = speedBits[0] & 0x7F;
            double speed;
//            if (speedMode == MACH) {
                speed = byteArrayToShort(speedBits, 2) * AIR_SPEED_UNIT_MACH;
//            } else {
//                speed = byteArrayToShort(speedBits, 2) * AIR_SPEED_UNIT_IAS;
//            }
            double angle = byteArrayToInt(angleBits, 2) * MAGNETIC_HEADING_UNIT;
            result -> groundSpeed = speed;
            result -> aircraftAngle = angle;
            printf("ground vector: speed is %lf, and angle is %lf\n", speed, angle);
            break;
        }
        case RATE_OF_TURN: {
            BYTE code = message[*index];
            *index += 1;
            printf("I021/165 data is %x\n", code);
            BYTE temp = code;
            
            while ((temp & 0x01) != 0) {
                //扩展字段，这里不解析，先做指针移动,解析在0.26版27页
                *index += 1;
            }
            break;
        }
        case TARGET_IDENTIFICATION: {
            BYTE code[6];
            memcpy(code, message + *index, 6);
            *index += 6;
            printf("I021/170 data is %x, %x, %x, %x, %x, %x\n", code[0], code[1], code[2], code[3], code[4], code[5]);
            decodeTargetId(code, result-> flightNo, 6, 8);
            break;
        }
        case VELOCITY_ACCURACY: {
            BYTE code = message[*index];
            *index += 1;
            printf("I021/095 data is %x\n", code);
            //0.26B版本page 15
            break;
        }
        case TIME_OF_DAY_ACCURACY: {
            BYTE code = message[*index];
            *index += 1;
            printf("I021/032 data is %x\n", code);
            break;
        }
        case TARGET_STATUS: {
            BYTE code = message[*index];
            *index += 1;
            printf("I021/200 data is %x\n", code);
            break;
        }
        case EMITTOR_CATEGORY: {
            BYTE emittor = message[*index];
            printf("emittor category is %x.\n", emittor);
            *index += 1;
            result -> emitterCategory = decodeEmitterCategory(emittor);
            break;
        }
        case MET_REPORT: {
            BYTE emittor = message[*index];
            printf("I021/220 data is %x\n", emittor);
            *index += 1;
            break;
        }
        case INTERMEDIATE_STATE_SELECTED_ALTITUDE: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/146 data is %x, %x\n", code[0], code[1]);
            //解码在p23
            break;
        }
        case FINAL_STATUS_SELECTED_ALTITUDE: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/148 data is %x, %x\n", code[0], code[1]);
            //解码在p24
            break;
        }
        case TRAJECTORY_INTENT: {
            BYTE code = message[*index];
            *index += 1;
            if (code << 7 != 0) {
                *index += 1;
            }
            //解码在p16
            if ((code << 1) >> 7 != 0) {
                *index += 1;
                *index += 15;
            }
            break;
        }
        case MODE_3A_CODE_IN_OCTAL_REPRESENTATION: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/070 data is %x, %x\n", code[0], code[1]);
            break;
        }
        case SIGNAL_AMPLITUDE: {
            BYTE code = message[*index];
            printf("I021/131 data is %x.\n", code);
            *index += 1;
            break;
        }
        default:
            break;
    }
}


