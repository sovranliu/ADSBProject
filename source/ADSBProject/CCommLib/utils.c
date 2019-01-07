//
//  utils.c
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/3.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "utils.h"
#include "global.h"
#include <string.h>

int byteArrayToInt(BYTE bytes[], int count) {
    if (bytes == NULL) {
        return -1;
    }
    int result = 0;
    for (int i = 0; i < count; i++) {
        BYTE b = bytes[i];
        result += (b << (count - i - 1) * 8);
    }
    return result;
}

short byteArrayToShort(BYTE bytes[], int count) {
    if (bytes == NULL) {
        return -1;
    }
    short result = 0;
    for (int i = 0; i < count; i++) {
        BYTE b = bytes[i];
        result += (b << (count - i - 1) * 8);
    }
    return result;
}

LONGX byteArrayToLong(BYTE bytes[], int count) {
    if (bytes == NULL) {
        return -1;
    }
    LONGX result = 0;
    for (int i = 0; i < count; i++) {
        LONGX b = bytes[i];
        result += (b << (count - i - 1) * 8);
    }
    return result;
}

void stringToBytrArray(char* dest, char* src) {
    while(*src) {
        if(' ' == *src) {
            src++;
            continue;
        }
        sscanf(src, "%02X", dest);
        src += 2;
        dest++;
    }
}
//统一取低6位
char decodeCharacter(BYTE byte) {
    byte = byte & 0x3F;
    BYTE bit65 = byte >> 4;
    BYTE bit4321 = byte & 0x0F;
    char result = 0;
    switch (bit65) {
        case 0:
            if (bit4321 > 0) {
                result = 'A' + bit4321 - 1;
            }
            break;
        case 1:
            if (bit4321 <= 10) {
                result = 'P' + bit4321;
            }
            break;
        case 2:
            if (bit4321 == 0) {
                result = ' ';
            }
            break;
        case 3:
            if (bit4321 < 10) {
                result = '0' + bit4321;
            }
            break;
            
        default:
            break;
    }
    return result;
}

int getFspecByteCount(BYTE message[]) {
    if (message == NULL) {
        return -1;
    }
    int count = 0;
    for (int i = 3; ; i++) {
        BYTE b = message[i];
        b = b << 7;
        b = b >> 7;
        count++;
        if (b != 1) {
            break;
        }
    }
    return count;
}

void decodeTargetId(BYTE src[], char* dest, int srcSize, int destSize) {
    unsigned LONGX bitslong = byteArrayToLong(src, srcSize);
    for (int i = destSize - 1; i >= 0; i--) {
        BYTE b = (bitslong >> ((destSize - i - 1) * 6)) & 0x000000000000003F;
        dest[i] = decodeCharacter(b);
    }
}

int stringArrayToByteArray(char* stringArray, BYTE* byteArray) {
    int n = 0;
    for (int i = 0; stringArray[i]; i += 2) {
        if (stringArray[i] >= 'A' && stringArray[i] <= 'F') {
            byteArray[n] = stringArray[i] - 'A' + 10;
        } else if (stringArray[i] >= '0' && stringArray[i] <= '9') {
            byteArray[n] = stringArray[i] - '0';
        } else {
            return n;
        }
        if (stringArray[i + 1] >= 'A' && stringArray[i + 1] <= 'F') {
            byteArray[n] = (byteArray[n] << 4) | (stringArray[i + 1] - 'A' + 10);
        } else if (stringArray[i + 1] >= '0' && stringArray[i + 1] <= '9') {
            byteArray[n] = (byteArray[n] << 4) | (stringArray[i + 1] - '0');
        } else {
            return n;
        }
        ++n;
    }
    return n;
}

void hexToChar(const BYTE byte, char* dest) {
    char high = byte >> 4;
    char low = byte & 0x0f;
    sprintf(&dest[0], "%X/n", high);
    sprintf(&dest[1], "%X/n", low);
}


