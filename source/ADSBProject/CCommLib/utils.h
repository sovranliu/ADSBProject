//
//  utils.h
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/3.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef utils_h
#define utils_h

#include <stdio.h>
#include "global.h"

#endif /* utils_h */

int byteArrayToInt(BYTE bytes[], int count);

short byteArrayToShort(BYTE bytes[], int count);

LONGX byteArrayToLong(BYTE bytes[], int count);

void stringToBytrArray(char* dest, char* src);

//六位编码解码成字符
char decodeCharacter(BYTE byte);

void decodeTargetId(BYTE src[], char* dest, int srcSize, int destSize);

int getFspecByteCount(BYTE message[]);

//十六进制数转换为字符串，比如0x3A，转换成“3A"
void hexToChar(const BYTE byte, char* dest);

//十六进制字符串转换为byte[]

#ifdef __cplusplus
extern "C" {
#endif
    int stringArrayToByteArray(char* stringArray, BYTE* byteArray);
#ifdef __cplusplus
};
#endif
