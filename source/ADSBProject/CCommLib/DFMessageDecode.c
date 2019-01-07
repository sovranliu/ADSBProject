//
//  DF1718Decode.c
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/10.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "DFMessageDecode.h"
#include "utils.h"
#include "string.h"
#include <stdlib.h>
#include <math.h>
#include "cpr_decode.h"
#include "altitude_decode.h"
#include "range_validation.h"
#include "message_type.h"

//8D

void decodeAircraftId(BYTE meField[], Cat021Data* result);

void decodeVelocity(BYTE meField[], Cat021Data* result);

void decodePosition(BYTE positionType, bool lastUpdateEven, BYTE meEven[], BYTE meOdd[], Cat021Data* result);

//飞行器种类
EmitterCategory decodeEmitterCategoryDF(BYTE bit0);

//奇偶配对后的实际解析入口
Cat021Data decodeDFMessage(DFMessage dfMessage) {
    Cat021Data cat021;
    resetCat021Message(&cat021);
    if (!dfMessage.paired) {
        printf("df message not paired\n");
        return cat021;
    }
    cat021.sModeAddress = dfMessage.icao;
    decodeAircraftId(dfMessage.aircraftId, &cat021);
    decodeVelocity(dfMessage.aircraftVelocity, &cat021);
    decodePosition(dfMessage.positionType, dfMessage.lastUpdateEven, dfMessage.positionEven, dfMessage.positionOdd, &cat021);
    return cat021;
}

void decodeAircraftId(BYTE meField[], Cat021Data* result) {
    BYTE bit0 = meField[0];
    result -> emitterCategory = decodeEmitterCategoryDF(bit0);
    BYTE code[6];
    memcpy(code, meField + 1, 6);
    decodeTargetId(code, result -> flightNo, 6, 8);
    result -> flightNo[8] = 0;
}

void decodeVelocity(BYTE meField[], Cat021Data* result) {
    int index = 0;
    BYTE byte0 = meField[0];
    index ++;
    int type = byte0 >> 3;
    int subType = byte0 & 0x07;
    printf("decode velocity: meField: %x %x %x %x %x %x %x\n", meField[0], meField[1], meField[2], meField[3], meField[4], meField[5], meField[6]);
    unsigned LONGX meBits = byteArrayToLong(meField, 7);
    if (subType == 1 || subType == 2) {
        BYTE ewVelocityValid, nsVelocityValid;
        BYTE ewDirection = (meBits << 21) >> 63;
        short ewVelocity = (meBits << 22) >> 54;
        BYTE nsDirection = (meBits << 32) >> 63;
        short nsVelocity = (meBits << 33) >> 54;
        double ewV = -1, nsV = -1;
    
        ewVelocityValid = 1;
        if (ewVelocity == 1023) {
            ewV = 1021.5;
        } else{
            ewV = ewVelocity - 1;
        }
    
        nsVelocityValid = 1;
        if (nsVelocity == 1023) {
            nsV = 1021.5;
        } else {
            nsV = nsVelocity - 1;
        }
        
        if (subType == 2) {
            ewV *= 4;
            nsV *= 4;
        }
        printf("ew velocity is %lf, ns velocity is %lf\n", ewV, nsV);
        double velocity = sqrt(ewV * ewV + nsV * nsV);
        double angle;
        if (ewDirection == 0 && nsDirection == 0) {
            angle = 90 - atan(nsV / ewV) * 180 / PI;
        } else if (ewDirection == 0 && nsDirection == 1) {
            angle = 90 + atan(nsV / ewV) * 180 / PI;
        } else if (ewDirection == 1 && nsDirection == 0) {
            angle = 270 + atan(nsV / ewV) * 180 / PI;
        } else if(ewDirection == 1 && nsDirection == 1) {
            angle = 270 - atan(nsV / ewV) * 180 / PI;
        }
        if (isnan(angle)) {
            angle = 0;
        }
        result -> airSpeed = velocity;
        result -> aircraftAngle = angle;
        printf("total velocity is %lf, angle is %lf\n", velocity, angle);
    } else {
        BYTE headingStatus = (meBits << 21) >> 63;
        short heading = (meBits << 22) >> 54;
        BYTE airspeedType = (meBits << 32) >> 63; //0 IAS(indicated airspeed), 1 TAS(true airspeed)
        short airspeedBits = (meBits << 33) >> 54;
        double headingDegree = heading * HEADING_UNIT;
        double airspeed;
        if (airspeedBits == 1023) {
            airspeed = 1021.5;
        } else {
            airspeed = airspeedBits - 1;
        }
        if (subType == 4) {
            airspeed *= 4;
        }
        result -> airSpeed = airspeed;
        result -> aircraftAngle = headingDegree;
        printf("airspeed type is %d, airspeed is %lf, angle is %lf\n", airspeedType, airspeed, headingDegree);
    }
}

void decodePosition(BYTE positionType, bool lastUpdateEven, BYTE meEven[], BYTE meOdd[], Cat021Data* result) {
    unsigned LONGX evenBits = byteArrayToLong(meEven, 7);
    unsigned LONGX oddBits = byteArrayToLong(meOdd, 7);
    unsigned LONGX newBits;
    if (lastUpdateEven) {
        newBits = evenBits;
    } else {
        newBits = oddBits;
    }
    if (positionType == AIRBORNE_POSITION) {
        short altitudeBits = (newBits << 16) >> 52;
        BYTE hei1 = (altitudeBits >> 4) & 0xFF;
        BYTE hei2 = (altitudeBits & 0x0F) << 4;
        int altitude = altitude_decode(hei1, hei2);
        result -> barometricAltitude = altitude;
    } else {
        BYTE headingStatus = (newBits << 20) >> 63;
        BYTE heading = (newBits << 21) >> 57;
        double angle = heading * 360.0 / 128;
        result -> aircraftAngle = angle;
    }
    int latEven = (evenBits << 30) >> 47;
    int lonEven = (evenBits << 47) >> 47;
    int latOdd = (oddBits << 30) >> 47;
    int lonOdd = (oddBits << 47) >> 47;
//    LatLong latlon = cpr_decode_global(latEven, lonEven, latOdd, lonOdd, positionType);
    LatLong latlon;
    if (lastUpdateEven) {
        latlon = cpr_decode_local(latEven, lonEven, ref_latLon.lat, ref_latLon.lon, positionType, 0);
    } else {
        latlon = cpr_decode_local(latOdd, lonOdd, ref_latLon.lat, ref_latLon.lon, positionType, 1);
    }
    if (latlon.valid != 0) {
        result -> latitude = latlon.lat;
        result -> longtitude = latlon.lon;
    } else {
        result -> sModeAddress = -1;
    }
        
//    if (latlon.valid != 0) {
////        result -> latitude = latlon.lat;
////        result -> longtitude = latlon.lon;
////        if (gps_latLon.valid != 0) {
////            double range = range_validation(gps_latLon.lat, gps_latLon.lon, latlon.lat, latlon.lon);
////            if (range < restrict_distance) {
//                //在最大接收范围内，进行本地解码
//                ref_latLon = latlon;
//                if (ref_latLon.valid == 1) {
//                    LatLong localLatLon = cpr_decode_local(latEven, lonEven, ref_latLon.lat, ref_latLon.lon, positionType, 0);
//                    LatLong locatLatLon2 = cpr_decode_local(latOdd, lonOdd, ref_latLon.lat, ref_latLon.lon, positionType, 1);
//                    if (localLatLon.valid == 1) {
//                        if (abs(localLatLon.lat - latlon.lat) < 0.001
//                            && abs(localLatLon.lon - latlon.lon) < 0.001) {
//                            result -> latitude = latlon.lat;
//                            result -> longtitude = latlon.lon;
//                        }
//                    }
//                }
////            }
////        }
//    }
}

EmitterCategory decodeEmitterCategoryDF(BYTE bit0) {
    BYTE type = bit0 >> 3 & 0xFF;
    BYTE emitCatBit = bit0 & 0x07;
	EmitterCategory result = EC_UNKNOWN;
    if (type == 1) { //D
        result = EC_UNKNOWN;
    } else if (type == 2) { //C
        
    } else if(type == 3) {//B
        if (emitCatBit == 1) {
            result = GLIDER;
        } else if (emitCatBit == 2) {
            result = LIGHT_THAN_AIR;
        } else if (emitCatBit == 3) {
            result = PARACHUTIST;
        } else if (emitCatBit == 4) {
            result = GLIDER;
        } else if (emitCatBit == 6) {
            result = UNMANNED_AERIAL_VEHICLE;
        }
    } else if (type == 4) {
        if (emitCatBit == 1) {
            result = LIGHT_AIRCRAFT;
        } else if (emitCatBit == 2) {
            result =LIGHT_AIRCRAFT;
        } else if (emitCatBit == 3) {
            //大型飞机
        } else if (emitCatBit == 5) {
            //重型飞机
        } else if (emitCatBit == 7) {
            result = ROTOCRAFT;
        }
    }
    return result;
}

