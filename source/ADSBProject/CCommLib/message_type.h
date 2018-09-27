//
//  message_type.h
//  adsbDecoder
//
//  Created by YangHongbing on 18/2/28.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef message_type_h
#define message_type_h

#include <stdio.h>
#include "global.h"
#include "DFMessage.h"

#endif /* message_type_h */

//解析消息类型，DF17, DF18, CAT021
#ifdef __cplusplus
extern "C" {
#endif
    BYTE getMessageType(BYTE message[]);
#ifdef __cplusplus
};
#endif


//解析DF消息的icao地址
#ifdef __cplusplus
extern "C" {
#endif
    int getDFMessageICAO(BYTE message[]);
#ifdef __cplusplus
};
#endif


//清空DF消息
#ifdef __cplusplus
extern "C" {
#endif
    void resetDFMessage(DFMessage* dfMessage);
#ifdef __cplusplus
};
#endif

//清空cat021消息
#ifdef __cplusplus
extern "C" {
#endif
    void resetCat021Message(Cat021Data* cat021);
#ifdef __cplusplus
};
#endif

//cat021转换飞机类型，输入位协议中定义的数据，输出为枚举的数值
#ifdef __cplusplus
extern "C" {
#endif
    EmitterCategory decodeEmitterCategory(BYTE byte);
#ifdef __cplusplus
};
#endif



