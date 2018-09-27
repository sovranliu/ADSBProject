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

char* decodeTargetId(BYTE byte[], int size, int toSize);

int getFspecByteCount(BYTE message[]);

