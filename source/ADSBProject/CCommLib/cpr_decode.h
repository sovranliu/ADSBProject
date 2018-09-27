//
//  cpr_decode.h
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/23.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#ifndef cpr_decode_h
#define cpr_decode_h

#include <stdio.h>
#include "global.h"


#endif /* cpr_decode_h */


LatLong cpr_decode_global(int lat_even, int lon_even, int lat_odd, int lon_odd, BYTE loc);

LatLong cpr_decode_local(int lat, int lon, double lat_ref, double lon_ref, BYTE loc, BYTE odd_even);

