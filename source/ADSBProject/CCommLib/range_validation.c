//
//  range_validation.c
//  adsbDecoder
//
//  Created by YangHongbing on 18/3/12.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "range_validation.h"
#include <math.h>

double X0, Y0, Z0;           /*self relative to earth's core*/
double X1, Y1, Z1;           /*enemy relative to earth's core*/
double x, y, z;              /*enemy relative to self*/
double N, W;


double m_Lon1;
double m_Lat1;     /*target*/
double m_Lon0;
double m_Lat0;    /*self*/
double m_D;

double range_validation(double ref_lat, double ref_lon, double lat, double lon) {
    m_Lon1 = lon;
    m_Lat1 = lat;
    
    m_Lon0 = ref_lon;
    m_Lat0 = ref_lat;
    
    W = sqrt(1-e*e*sin(m_Lat0/57.29578)*sin(m_Lat0/57.29578));
    N = alpha/W;
    X0 = (N)*cos(m_Lat0/57.29578)*cos(m_Lon0/57.29578);
    Y0 = (N)*cos(m_Lat0/57.29578)*sin(m_Lon0/57.29578);
    Z0 = (N*(1-e*e))*sin(m_Lat0/57.29578);
    
    W = sqrt(1-e*e*sin(m_Lat1/57.29578)*sin(m_Lat1/57.29578));
    N = alpha/W;
    X1 = (N)*cos(m_Lat1/57.29578)*cos(m_Lon1/57.29578);
    Y1 = (N)*cos(m_Lat1/57.29578)*sin(m_Lon1/57.29578);
    Z1 = (N*(1-e*e))*sin(m_Lat1/57.29578);
    
    x = -sin(m_Lat0/57.29578)*cos(m_Lon0/57.29578)*(X1-X0)
    - sin(m_Lat0/57.29578)*sin(m_Lon0/57.29578)*(Y1-Y0)
    + cos(m_Lat0/57.29578)*(Z1-Z0);
    y = -sin(m_Lon0/57.29578)*(X1-X0) + cos(m_Lon0/57.29578)*(Y1-Y0);
    z = cos(m_Lat0/57.29578)*cos(m_Lon0/57.29578)*(X1-X0)
    + cos(m_Lat0/57.29578)*sin(m_Lon0/57.29578)*(Y1-Y0)
    + sin(m_Lat0/57.29578)*(Z1-Z0);
    
    if(x >= 0 && x < 0.000001)
        x = 0.000001;
    else if(x < 0 && x > -0.000001)
        x = -0.000001;
    
    m_D = (float)sqrt(x*x+y*y)/1000;    /*dis(km)*/
    
    return m_D;
}
