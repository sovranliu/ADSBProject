//
//  message_type.c
//  adsbDecoder
//
//  Created by YangHongbing on 18/2/28.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "message_type.h"
#include "utils.h"
#include <string.h>
#include "DFMessage.h"


BYTE getMessageType(BYTE message[]) {
    if (message == NULL) {
        return 0;
    }
    BYTE byte0 = message[0];
    if (byte0 == 21) {
        return CAT021;
    }
    BYTE num0 = byte0 >> 3;
    if (num0 == 17) {
        return DF17;
    }
    if (num0 == 18) {
        return DF18;
    }
    return 0;
}

int getDFMessageICAO(BYTE message[]) {
    if (message == NULL) {
        return 0;
    }
    BYTE icaoBits[3];
    memcpy(icaoBits, message, 3);
    int icao = byteArrayToInt(icaoBits, 3);
    return icao;
}

void resetDFMessage(DFMessage* dfMessage) {
    if (dfMessage == NULL) {
        return;
    }
    dfMessage -> df = 0;
    dfMessage -> time = -1;
    dfMessage -> icao = 0;
    dfMessage -> paired = false;
    dfMessage -> lastUpdateEven = false;
    dfMessage -> positionType = 0;
    BYTE nullMessage[7] = {0};
    memcpy(dfMessage -> positionEven, nullMessage, 7);
    memcpy(dfMessage -> positionOdd, nullMessage, 7);
    memcpy(dfMessage -> aircraftVelocity, nullMessage, 7);
    memcpy(dfMessage -> aircraftId, nullMessage, 7);
}

void resetCat021Message(Cat021Data* cat021) {
    if (cat021 == NULL) {
        return;
    }
    cat021 -> sModeAddress = 0;
    cat021 -> flightNo[0] = '\0';
    cat021 -> latitude = 0;
    cat021 -> longtitude = 0;
    cat021 -> elapsedTime = 0;
    cat021 -> geometricAltitude = 0;
    cat021 -> barometricAltitude = 0;
    cat021 -> airSpeed = 0;
    cat021 -> airSpeedUnit = 0;
    cat021 -> aircraftAngle = 0;
    cat021 -> groundSpeed = 0;
    cat021 -> emitterCategory = EC_UNKNOWN;
}

EmitterCategory decodeEmitterCategory(BYTE byte) {
    EmitterCategory result = EC_UNKNOWN;
    switch (byte) {
        case 1:
            result = LIGHT_AIRCRAFT;
            break;
        case 3:
            result = MEDIUM_AIRCRAFT;
            break;
        case 5:
            //重型飞机
            break;
        case 10:
            result = ROTOCRAFT;
            break;
        case 11:
            result = GLIDER;
            break;
        case 12:
            result = LIGHT_THAN_AIR;
            break;
        case 13:
            result = UNMANNED_AERIAL_VEHICLE;
            break;
        case 15:
            result = LIGHT_THAN_AIR;
            break;
        case 16:
            result = PARACHUTIST;
            break;
        default:
            break;
    }
    return result;
}

