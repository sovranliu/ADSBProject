//
//  cpr_decode.c
//  adsbDecoder
//
//  Created by yanghongbing on 18/2/23.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "cpr_decode.h"
#include "math.h"
#include "DFMessage.h"
#define NZ 15

int NL(double x);

double mod(double num1, double num2);

//全球解码
LatLong cpr_decode_global(int lat_even, int lon_even, int lat_odd, int lon_odd, BYTE loc) {
    LatLong latlon;
    latlon.valid = 0;
    double dlat0, dlat1; //分别是偶编码和奇编码的dlat
    int Nb;
    if (loc == AIRBORNE_POSITION) {
        dlat0 = 360.0 / (4 * NZ - 0);
        dlat1 = 360.0 / (4 * NZ - 1);
        Nb = 17;
    } else {
        dlat0 = 90.0 / (4 * NZ - 0);
        dlat1 = 90.0 / (4 * NZ - 1);
        //有资料上说地面参数为19，但是文档还是17位
        Nb = 17;
    }
    short lat_j = floor((59.0 * lat_even - 60.0 * lat_odd) / pow(2, Nb) + 1.0/2);
    double rlat0, rlat1;
    rlat0 = dlat0 * (lat_j % 60 + 1.0 * lat_even / pow(2, Nb));
    rlat1 = dlat1 * (lat_j % 59 + 1.0 * lat_odd / pow(2, Nb));
    if (rlat0 > 90) {
        rlat0 -= 360;
    }
    if (rlat1 > 90) {
        rlat1 -= 360;
    }
    double nl0, nl1;
    nl0 = NL(rlat0);
    nl1 = NL(rlat1);
    if (nl0 != nl1) {
        printf("奇偶NL不等，等带下一个消息\n");
        return latlon;
    }
    double n0 = nl0 > 1 ? nl0 : 1;
    double n1 = nl1 - 1 > 1 ? nl1 - 1 : 1;
    double dlon0, dlon1;
    if (loc == AIRBORNE_POSITION) {
        dlon0 = 360 / n0;
        dlon1 = 360 / n1;
    } else {
        dlon0 = 90 / n0;
        dlon1 = 90 / n1;
    }
    int lon_m = floor((lon_even * (nl0 - 1) - lon_odd * nl1) / pow(2, Nb) + 1.0/2);
    double rlon0, rlon1;
    rlon0 = dlon0 * (mod(lon_m, n0) + 1.0 * lon_even / pow(2, Nb));
    rlon1 = dlon1 * (mod(lon_m, n1) + 1.0 * lon_odd / pow(2, Nb));
    if (rlon0 < -180) {
        rlon0 += 360;
    } else if (rlon0 > 180) {
        rlon0 -= 360;
    }
    if (rlon1 < -180) {
        rlon1 += 360;
    } else if (rlon1 > 180) {
        rlon1 -= 360;
    }
    latlon.valid = 1;
    latlon.lat = rlat0;
    latlon.lon = rlon0;
    return latlon;
}

//本地解码
LatLong cpr_decode_local(int lat, int lon, double lat_ref, double lon_ref, BYTE loc, BYTE odd_even) {
    LatLong latlon;
    latlon.valid = 0;
    double dlat;
    int Nb;
    if (loc == AIRBORNE_POSITION) {
        dlat = 360.0 / (4 * NZ - odd_even);
        Nb = 17;
    } else {
        dlat = 90.0 / (4 * NZ - odd_even);
        //有资料上说地面参数为19，但是文档还是17位
        Nb = 17;
    }
    int lat_j;
    if (lat_ref > 0) {
        lat_j = floor(lat_ref / dlat) + floor(0.5 + mod(lat_ref, dlat) / dlat - 1.0 * lat / pow(2, Nb));
    } else {
        lat_j = floor(lat_ref / dlat) + floor(0.5 + mod(lat_ref + 360, dlat) / dlat - 1.0 * lat / pow(2, Nb));
    }
    
    double rlat = dlat * (lat_j + 1.0 * lat / pow(2, Nb));
    if (rlat > 90) {
        rlat -= 360;
    }
    if (rlat > 90) {
        rlat -= 360;
    }
    double nl = NL(rlat);
    double dlon;
    double num;
    if (loc == AIRBORNE_POSITION) {
        num = 360.0;
    } else {
        num = 90.0;
    }
    if (nl - odd_even > 0) {
        dlon = num / (nl - odd_even);
    } else {
        dlon = num;
    }
    double lon_j;
    if (lon_ref > 0) {
        lon_j = floor(lon_ref / dlon) + floor(0.5 + mod(lon_ref, dlon) / dlon - 1.0 * lon / pow(2, Nb));
    } else {
        lon_j = floor(lon_ref / dlon) + floor(0.5 + mod(lon_ref + 360, dlon) / dlon - 1.0 * lon / pow(2, Nb));
    }
    double rlon = dlon * (lon_j + 1.0 * lon / pow(2, Nb));
    if (rlon < -180) {
        rlon += 360;
    } else if (rlon > 180) {
        rlon -= 360;
    }
    latlon.valid = true;
    latlon.lat = rlat;
    latlon.lon = rlon;
    return latlon;
}

int NL(double x) {
    int result = floor(2 * PI / (acos(1 - ((1 - cos( PI / (2 * NZ))) / (cos(PI / 180 * fabs(x)) * cos(PI / 180 * fabs(x)))))));
    return result;
}

double mod(double num1, double num2) {
    if (fabs(num2) < 0.00000001) {
        return num1;
    }
    return num1 - ((short) (num1 / num2)) * num2;
}
