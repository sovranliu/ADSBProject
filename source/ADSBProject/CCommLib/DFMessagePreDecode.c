//
//  DFMessagePreDecode.c
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/25.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "DFMessagePreDecode.h"
#include "utils.h"

DFMessageType getDFMessageType(BYTE byte);

void decodeMessageByType(BYTE meField[], DFMessageType messageType, DFMessage* dfMessage);

//预解析，只判断类型，不做具体字段解析，等配对后在DFMessageDecode中做具体解析
void preDecodeDFMessage(BYTE message[], DFMessage* dfMessage) {
    int start = 0;
    int* dataIndex = &start; //数据指针，指到读取的位置
    BYTE byte0 = message[*dataIndex];
    *dataIndex += 1;
    int df = byte0 >> 3;
    dfMessage -> df = df;
    printf("this is a DF %d message.\n", df);
    BYTE AAFiled[3];
    memcpy(AAFiled, message + *dataIndex, 3);
    *dataIndex += 3;
    int icao = byteArrayToInt(AAFiled, 3);
    dfMessage -> icao = icao;
    printf("icao address is %x\n" , icao);
    BYTE meField[7];
    memcpy(meField, message + *dataIndex, 7);
    printf("mefield is %x, %x, %x, %x, %x, %x, %x\n", meField[0], meField[1], meField[2], meField[3], meField[4], meField[5], meField[6]);
    *dataIndex += 7;
    BYTE meByte0 = meField[0];
    BYTE type = meByte0 >> 3;
    BYTE subType = meByte0 & 0x07;
    DFMessageType messageType = getDFMessageType(meByte0);
    decodeMessageByType(meField, messageType, dfMessage);
}

DFMessageType getDFMessageType(BYTE byte) {
    int type = byte >> 3;
    int subType = byte & 0x07;
    DFMessageType messageType = TYPE_NULL;
    if (type == 0) {
        messageType = TYPE_NULL;
    } else if (type >= 1 && type <= 4) {
        messageType = AircraftID_AND_TYPE;
    } else if (type >= 5 && type <= 8) {
        messageType = SURFACE_POSITION;
    } else if (type >= 9 && type <= 18) {
        messageType = AIRBORNE_POSITION;
    } else if (type == 19) {
        if (subType >= 1 && subType <= 4) {
            messageType = AIRBORNE_VELOCITY;
        } else {
            messageType = TYPE_RESERVED;
        }
    } else if (type >= 20 && type <= 22) {
        messageType = AIRBORNE_POSITION;
    } else {
        messageType = TYPE_RESERVED;
    }
    return messageType;
}

void decodeMessageByType(BYTE meField[], DFMessageType messageType, DFMessage* dfMessage) {
    unsigned LONGX meBits = byteArrayToLong(meField, 7);
    switch (messageType) {
        case AircraftID_AND_TYPE: {
            memcpy(dfMessage -> aircraftId, meField, 7);
//            BYTE code[6];
//            memcpy(code, meField + 1, 6);
//            char* aircraftId = decodeTargetId(code, 6, 8);
//            printf("aircraft id is %s\n", aircraftId);
//            free(aircraftId);
            break;
        }
        case AIRBORNE_POSITION: {
            dfMessage -> positionType = AIRBORNE_POSITION;
            BYTE cprFormat = (meBits << (21 + 8)) >> 63;
            dfMessage -> lastUpdateEven = cprFormat;
            if (cprFormat == 1) {
                memcpy(dfMessage -> positionOdd, meField, 7);
            } else {
                memcpy(dfMessage -> positionEven, meField, 7);
            }
            if (dfMessage -> positionOdd[0] != 0
                && dfMessage -> positionEven[0] != 0) {
                dfMessage -> paired = true;
            }
            break;
        }
        case AIRBORNE_VELOCITY: {
            memcpy(dfMessage -> aircraftVelocity, meField, 7);
            break;
        }
            
        case SURFACE_POSITION: {
            dfMessage -> positionType = SURFACE_POSITION;
            BYTE cprFormat = (meBits << (21 + 8)) >> 63;
            dfMessage -> lastUpdateEven = cprFormat;
            if (cprFormat == 1) {
                memcpy(dfMessage -> positionOdd, meField, 7);
            } else {
                memcpy(dfMessage -> positionEven, meField, 7);
            }
            if ((dfMessage -> positionOdd) != NULL
                && ((dfMessage -> positionEven) != NULL)) {
                dfMessage -> paired = true;
            }
            break;
        }
        default:
            break;
    }
}

