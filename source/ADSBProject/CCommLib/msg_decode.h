//
//  msg_decode.h
//  adsbDecoder
//
//  Created by YangHongbing on 18/3/1.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef msg_decode_h
#define msg_decode_h


#endif /* msg_decode_h */

extern "C" _declspec(dllexport) void init();

extern "C" _declspec(dllexport) bool decodeMessage(BYTE message[]);

extern "C" _declspec(dllexport) void setGPSLatLong(double latitude, double longtitude);

extern "C" _declspec(dllexport) void setCat021Version(BYTE version);
