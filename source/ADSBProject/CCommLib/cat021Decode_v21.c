//
//  cat021Decode_v21.c
//  adsbDecoder
//
//  Created by YangHongbing on 18/2/7.
//  Copyright © 2018年 qiandian. All rights reserved.
//
#include "global.h"
#include <string.h>
#include <math.h>
#include <malloc.h>
#include <stdlib.h>
#include "cat021Decode_v21.h"
#include "utils.h"
#include "message_type.h"

void decodeDataItem21(CAT021_21_ITEM item, BYTE message[], int* index, Cat021Data* result);

Cat021Data decodeCAT021V21(BYTE message[]) {
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
                    CAT021_21_ITEM type = i * 8 + bitIndex;
                    decodeDataItem21(type, message, dataIndex, &result);
                }
            }
            
        }
    }
    return result;
}

void decodeDataItem21(CAT021_21_ITEM item, BYTE message[], int* index, Cat021Data* result) {
    switch (item) {
        case _DATA_SOURCE_IDENTIFICATION: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("sac code is %x\n", code[0]);
            printf("sic code is %x\n", code[1]);
            break;
        }
        case _TARGET_REPORT_DESCRIPTION: {
            BYTE code = message[*index];
            *index += 1;
            int extension = code & 0x01;
            while (extension != 0) {
                BYTE b = message[*index];
                *index += 1;
                extension = b & 0x01;
            }
            break;
        }
        case _TRACKER_NUMBER: {
            *index += 2;
            break;
        }
        case _SERVICE_IDENTIFICATION: {
            *index += 1;
            break;
        }
        case _TIME_OF_APPLICABILITY_FOR_POSITION: {
            *index += 3;
            break;
        }
        case _POSITION_IN_WGS_84_COORDINATES: {
            BYTE latbits[3], lonbits[3];
            memcpy(latbits, message + *index, 3);
            *index += 3;
            memcpy(lonbits, message + *index, 3);
            *index += 3;
            double latitude = byteArrayToInt(latbits, 3) * LATLON_UNIT;
            double longtitude = byteArrayToInt(lonbits, 3) * LATLON_UNIT;
            result -> latitude = latitude;
            result -> longtitude = longtitude;
            printf("latitude is %lf, longtitude is %lf\n", latitude, longtitude);
            break;
        }
        case _POSITION_IN_WGS_84_COORDINATES_HIGH_RES: {
            BYTE latbits[4], lonbits[4];
            memcpy(latbits, message + *index, 4);
            *index += 4;
            memcpy(lonbits, message + *index, 4);
            double latitude = byteArrayToInt(latbits, 4) * LATLON_UNIT_HIGH_RES;
            double longtitude = byteArrayToInt(lonbits, 4) * LATLON_UNIT_HIGH_RES;
            printf("hight res : latitude is %lf, longtitude is %lf\n", latitude, longtitude);
            break;
        }
        case _TIME_OF_APPLICABILITY_FOR_VELOCITY: {
            *index += 3;
            break;
        }
        case _AIRSPEED: {
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
        case _TRUE_AIRSPEED: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/151 data is %x, %x\n", code[0], code[1]);
            double trueSpeed = byteArrayToShort(code, 2) * TRUE_AIR_SPEED;
            printf("true speed is %lf\n", trueSpeed);
            break;
        }
        case _TARGET_ADDRESS: {
            BYTE code[3];
            memcpy(code, message + *index, 3);
            printf("I021/080 data is %x, %x, %x\n", code[0], code[1], code[2]);
            *index += 3;
            int address = byteArrayToInt(code, 3);
            result->sModeAddress = address;
            printf("target address is %d\n", address);
            break;
        }
        case _TIME_OF_MESSAGE_RECEPTION_OF_POSITION: {
            *index += 3;
            break;
        }
        case _TIME_OF_MESSAGE_RECEPTION_OF_POSITION_HIGH_PRECISION: {
            *index += 4;
            break;
        }
        case _TIME_OF_MESSAGE_RECEPTION_OF_VELOCITY: {
            *index += 3;
            break;
        }
        case _TIME_OF_MESSAGE_RECEPTION_OF_VELOCITY_HIGH_PRECISION: {
            *index += 4;
            break;
        }
        case _GEOMETRIC_HEIGHT: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            double altitude = byteArrayToShort(code, 2) * ALTITUDE_UNIT;
            result -> geometricAltitude = altitude;
            break;
        }
        case _QUALITY_INDICATORS: {
            BYTE code = message[*index];
            *index += 1;
            int extension = code & 0x01;
            while (extension != 0) {
                BYTE b = message[*index];
                *index += 1;
                extension = b & 0x01;
            }
            break;
        }
        case _MOPS_VERSION: {
            *index += 1;
            break;
        }
        case _MODE_3_A_CODE: {
            *index += 2;
            break;
        }
        case _ROLL_ANGEL: {
            *index += 2;
            break;
        }
        case _FLIGHT_LEVEL: {
            BYTE code[2];
            memcpy(code, message + *index, 2);
            *index += 2;
            printf("I021/145 data is %x, %x\n", code[0], code[1]);
            double barometricHeight = byteArrayToShort(code, 2) * FLIGHT_LEVEL_UNIT;
            result -> barometricAltitude = barometricHeight;
            printf("barometric height is %lf\n", barometricHeight);
            break;
        }
        case _MAGNETIC_HEADING: {
            *index += 2;
            break;
        }
        case _TARGET_STATUS: {
            *index += 1;
            break;
        }
        case _BAROMETRIC_VERTICAL_RATE: {
            *index += 2;
            break;
        }
        case _GEOMETRIC_VERTICAL_RATE: {
            *index += 2;
            break;
        }
        case _AIRBORNE_GROUND_VECTOR: {
            BYTE speedBits[2], angleBits[2];
            memcpy(speedBits, message + *index, 2);
            *index += 2;
            memcpy(angleBits, message + *index, 2);
            *index += 2;
            printf("ground vector data is %x, %x, %x, %x\n", speedBits[0], speedBits[1], angleBits[0], angleBits[1]);
            BYTE speedTopBit = speedBits[0] >> 7;
            speedBits[0] = speedBits[0] & 0x7F;
            if (speedTopBit == 1) {
                speedBits[0] = 0xFF;
            }
            double speed = byteArrayToShort(speedBits, 2) * AIR_SPEED_UNIT_IAS;
            result -> groundSpeed = speed;
            double angle = byteArrayToInt(angleBits, 2) * MAGNETIC_HEADING_UNIT;
            result -> aircraftAngle = angle;
            break;
        }
        case _TRACK_ANGLE_RATE: { //转弯角度
            *index += 2;
            break;
        }
        case _TIME_OF_REPORT_TRANSMISSION: {
            BYTE code[3];
            memcpy(code, message + *index, 3);
            *index += 3;
            printf("I021/077 data is %x, %x, %x\n", code[0], code[1], code[2]);
            double elapsedTime = byteArrayToInt(code, 3) * 1.0 / 128;
            printf("time of day value is %lf\n", elapsedTime);
            result -> elapsedTime = elapsedTime;
            break;
        }
        case _TARGET_IDENTIFICATION: {
            BYTE code[6];
            memcpy(code, message + *index, 6);
            *index += 6;
            printf("I021/170 data is %x, %x, %x, %x, %x, %x\n", code[0], code[1], code[2], code[3], code[4], code[5]);
            decodeTargetId(code, result -> flightNo, 6, 8);
            break;
        }
        case _EMITTOR_CATEGORY: {
            BYTE emitter = message[*index];
            *index += 1;
            result -> emitterCategory = decodeEmitterCategory(emitter);
            break;
        }
        case _MET_INFORMATION: {
            BYTE code = message[*index];
            if (code >> 7 != 0) {
                *index += 2;
            }
            if ((code << 1) >> 7 != 0) {
                *index += 2;
            }
            if ((code << 2) >> 7 != 0) {
                *index += 2;
            }
            if ((code << 3) >> 7 != 0) {
                *index += 2;
            }
            break;
        }
        case _SELECTED_ALTITUDE: {
            *index += 2;
            break;
        }
        case _FINAL_STATTE_SELECTED_ALTITUDE: {
            *index += 2;
            break;
        }
        case _TRAJECTORY_INTENT: {
            BYTE code = message[*index];
            if (code >> 7 != 0) {
                *index += 1;
            }
            if ((code << 1) >> 7 != 0) {
                *index += 16;
            }
            break;
        }
        case _SERVICE_MANAGEMENT: {
            *index += 1;
            break;
        }
        case _AIRCRAFT_OPERATIONAL_STATUS: {
            *index += 1;
            break;
        }
        case _SURFACE_CAPABILITIES_AND_CHARACTERISTICS: {
            BYTE code = message[*index];
            *index += 1;
            if ((code & 0x01) != 0) {
                *index += 1;
            }
            break;
        }
        case _MESSAGE_AMPLITUDE: {
            *index += 1;
            break;
        }
        case _MODE_S_MB_DATA: {
            BYTE code = message[*index];
            *index += 1;
            *index += 8 * code;
            break;
        }
        case _ACAS_RESOLUTION_ADVISORY_REPORT: {
            *index += 7;
            break;
        }
        case _RECEIVER_ID: {
            *index += 1;
            break;
        }
        case _DATA_AGES: {
            BYTE code = message[*index];
            *index += 1;
            int extension = code & 0x01;
            while (extension != 0) {
                BYTE b = message[*index];
                *index += 1;
                extension = b & 0x01;
            }
            break;
        }
        default:
            break;
    }
}
