//
//  altitude_decode.c
//  adsbDecoder
//
//  Created by YangHongbing on 18/3/9.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "altitude_decode.h"

unsigned char gray_change(unsigned char data_gray);

signed char gray_change1(unsigned char data_gray1);

signed char gray_change2(unsigned char data_gray2);


int altitude_decode(BYTE hei1,BYTE hei2)    /*hei1对应ME域9~16位，hei2对应ME域17~24，其中hei2只用高4位*/
{
    /*type:9~18为气压高度，type:20~22为GNSS高度*/
    int height_ads;
    unsigned char a1,a2,a3;
    signed char g1,g2;
    signed char g3;
    height_ads=0;
    if ((hei1&0x01)==0)
    {             /*原先编码见DO260B的60页，现将编码顺序变为3组格雷码，a1组编码为：D2 D4 A1 A2，a2组编码为：A4 B1 B2 B4，a3组编码为C1 C2 C4*/
        a1=((hei2&0x40)>>3)+((hei2&0x10)>>2)+((hei1&0x40)>>5)+((hei1&0x10)>>4);
        /*     D2               D4               A1              A2*/
        a2=((hei1&0x04)<<1)+((hei1&0x02)<<1)+((hei2&0x80)>>6)+((hei2&0x20)>>5);
        /*    A4                 B1              B2               B4*/
        a3=((hei1&0x80)>>5)+((hei1&0x20)>>4)+((hei1&0x08)>>3);
        /*   C1          C2            C4   */
        g1=gray_change(a1);
        g2=gray_change(a2);
        if ((g1%2)==0)  /*《空中交通管制机载应答机》的11页*/
        {   /*偶数列：g1*8000+(g2-2)*500*/
            height_ads=g1*8000+(g2-2)*500;
        }
        else   /*奇数列*/
        {
            height_ads=g1*8000+(13-g2)*500;
        }
        if ((height_ads%1000)==0)  /*如果以1000英尺结尾*/
        {
            g3=gray_change1(a3);
        }
        else
        {
            g3=gray_change2(a3);
        }
        height_ads=height_ads+g3*100;
    }
    return height_ads;
}
unsigned char gray_change(unsigned char data_gray)
{
    unsigned char data;
    switch(data_gray)
    {
        case 0x0 : data=0;break;
        case 0x1 : data=1;break;
        case 0x3 : data=2;break;
        case 0x2 : data=3;break;
        case 0x6 : data=4;break;
        case 0x7 : data=5;break;
        case 0x5 : data=6;break;
        case 0x4 : data=7;break;
        case 0xC : data=8;break;
        case 0xD : data=9;break;
        case 0xF : data=10;break;
        case 0xE : data=11;break;
        case 0xA : data=12;break;
        case 0xB : data=13;break;
        case 0x9 : data=14;break;
        case 0x8 : data=15;break;
        default : break;
    }
    return data;
}
signed char gray_change1(unsigned char data_gray1)
{
    signed char data1;
    data1=0;
    
    switch (data_gray1)
    {
        case 4 : data1=2;break;
        case 6 : data1=1;break;
        case 2 : data1=0;break;
        case 3 : data1=-1;break;
        case 1 : data1=-2;break;
        default : break;
    }
    return data1;
}
signed char gray_change2(unsigned char data_gray2)
{
    signed char data2;
    data2=0;
    switch (data_gray2)
    {
        case 1 : data2=2;break;
        case 3 : data2=1;break;
        case 2 : data2=0;break;
        case 6 : data2=-1;break;
        case 4 : data2=-2;break;
        default : break;
    }
    return data2;
}
