//
//  cat021Encode_v026.h
//  adsbDecoder
//
//  Created by YangHongbing on 18/4/25.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef cat021Encode_v026_h
#define cat021Encode_v026_h

#include <stdio.h>
#include "cat021Decode.h"

#ifdef __cplusplus
extern "C" {
#endif
	//编码为cat021，返回值为result的实际长度
	int encodeCat021V026(BYTE* result, Cat021Data data);

	//将上述函数转换成String输出
	char* encodeCat021V026String(Cat021Data data);
#ifdef __cplusplus
};
#endif

#endif /* cat021Encode_v026_h */
