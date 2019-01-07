//
//  cat021Encode_v026.c
//  adsbDecoder
//
//  Created by YangHongbing on 18/4/25.
//  Copyright © 2018年 qiandian. All rights reserved.
//

#include "cat021Encode_v026.h"
#include "utils.h"
#include <string.h>

void addSpec(int* fspec, CAT021_0_26_ITEM item);

int encodeTimeOfDay(double time, BYTE* result, int position);

int encodePosition(double latitude, double longtitude, BYTE* result, int position);

int encodeTargetAddress(int targetAddress, BYTE* result, int position);

int encodeGeometricAltitude(double geometricAltitude, BYTE* result, int position);

int encodeFlightLevel(double flightLevel, BYTE* result, int position);

int encodeAirSpeed(double airspeed, double airspeedUnit, BYTE* result, int position);

int encodeGroundVector(double groundSpeed, double aircraftAngle, BYTE* result, int position);

int encodeTargetIdentification(char flightId[], BYTE* result, int position);

BYTE encodeChar(char c);

int encodeEmitterCategory(BYTE emitterCategory, BYTE* result, int position);

void printByteArray(BYTE* bytes);

int encodeCat021V026(BYTE* result, Cat021Data data) {
	printf("\n\n encodeCat021V026\n");
	if (result == NULL) {
		return 0;
	}
	short length = 0;
	//第0位：cat021头部标识
	result[0] = 21;
	length += 1;
	//第1-2位：数据块总长度，预留，最后算
	length += 2;
	//Fspec，4个字节，第3-6位

	
	int fspec = 0;
	addSpec(&fspec, TARGET_ADDRESS);
	addSpec(&fspec, TARGET_IDENTIFICATION);
	addSpec(&fspec, TIME_OF_DAY);
	addSpec(&fspec, POSITION_IN_WGS_84_COORDINATES);
	addSpec(&fspec, GEOMETRIC_ALTITUDE);
	addSpec(&fspec, FLIGHT_LEVEL);
	addSpec(&fspec, AIR_SPEED);
	addSpec(&fspec, GROUND_VECTOR);
	addSpec(&fspec, EMITTOR_CATEGORY);
	addSpec(&fspec, EXT_0);
	addSpec(&fspec, EXT_1);
	addSpec(&fspec, EXT_2);
	result[length++] = fspec >> 24;
	result[length++] = (fspec << 8) >> 24;
	result[length++] = (fspec << 16) >> 24;
	result[length++] = (fspec << 24) >> 24;
	//从第7位开始为具体数据
	//time of day
	int l = encodeTimeOfDay(data.elapsedTime, result, length);
	length += l;
	//position
	l = encodePosition(data.latitude, data.longtitude, result, length);
	length += l;
	//target address
	l = encodeTargetAddress(data.sModeAddress, result, length);
	length += l;
	//geometric altitude
	l = encodeGeometricAltitude(data.geometricAltitude, result, length);
	length += l;
	//flight level
	l = encodeFlightLevel(data.barometricAltitude, result, length);
	length += l;
	//air speed
	l = encodeAirSpeed(data.airSpeed, data.airSpeedUnit, result, length);
	length += l;
	//ground vector
	l = encodeGroundVector(data.groundSpeed, data.aircraftAngle, result, length);
	length += l;
	//target id
	l = encodeTargetIdentification(data.flightNo, result, length);
	length += l;
	//emitter category
	l = encodeEmitterCategory(data.emitterCategory, result, length);
	length += l;
	result[1] = length >> 8;
	result[2] = length & 0xFF;
	return length;
}

char* encodeCat021V026String(Cat021Data data) {
	BYTE encoded[200];
	int length = encodeCat021V026(encoded, data);
	if (length > 0) {
		char* p = (char*)malloc((2 * length + 1) * sizeof(char));
		for (int ii = 0; ii < length; ii++) {
			BYTE b = encoded[ii];
			char str[3];
			char high = b >> 4;
			char low = b & 0x0f;
			sprintf(str, "%X", high);
			sprintf(str + 1, "%X", low);
			memcpy((p + 2 * ii), str, 2);
		}
		*(p + 2 * length) = 0;
		return p;
	}
	return NULL;
}

void addSpec(int* fspec, CAT021_0_26_ITEM item) {
	*fspec |= 1 << (31 - item);
}

int encodeTimeOfDay(double time, BYTE* result, int position) {
	int value = time * 128;
	result[position] = (value << 8) >> 24;
	result[position + 1] = (value << 16) >> 24;
	result[position + 2] = (value << 24) >> 24;
	printf("encodeTimeOfDay \n");
	printByteArray(result);
	return 3;
}

int encodePosition(double latitude, double longtitude, BYTE* result, int position) {
	int latValue = latitude / LATLON_UNIT;
	int lonValue = longtitude / LATLON_UNIT;
	result[position++] = (latValue << 0) >> 24;
	result[position++] = (latValue << 8) >> 24;
	result[position++] = (latValue << 16) >> 24;
	result[position++] = (latValue << 24) >> 24;
	result[position++] = (lonValue << 0) >> 24;
	result[position++] = (lonValue << 8) >> 24;
	result[position++] = (lonValue << 16) >> 24;
	result[position++] = (lonValue << 24) >> 24;
	printf("encodePosition \n");
	printByteArray(result);
	return 8;
}

int encodeTargetAddress(int targetAddress, BYTE* result, int position) {
	result[position++] = (targetAddress << 8) >> 24;
	result[position++] = (targetAddress << 16) >> 24;
	result[position++] = (targetAddress << 24) >> 24;
	printf("encodeTargetAddress \n");
	printByteArray(result);
	return 3;
}

int encodeGeometricAltitude(double geometricAltitude, BYTE* result, int position) {
	short altitudeValue = geometricAltitude / ALTITUDE_UNIT;
	result[position++] = altitudeValue >> 8;
	result[position++] = (altitudeValue << 8) >> 8;
	printf("encodeGeometricAltitude \n");
	printByteArray(result);
	return 2;
}

int encodeFlightLevel(double flightLevel, BYTE* result, int position) {
	short flightLevelValue = flightLevel / FLIGHT_LEVEL_UNIT;
	result[position++] = flightLevelValue >> 8;
	result[position++] = (flightLevelValue << 8) >> 8;
	printf("encodeFlightLevel \n");
	printByteArray(result);
	return 2;
}

int encodeAirSpeed(double airspeed, double airspeedUnit, BYTE* result, int position) {
	short airspeedValue;
	if (airspeedUnit == MACH) {
		airspeedValue = airspeed / AIR_SPEED_UNIT_MACH;
		airspeedValue |= 0x8000;
	}
	else {
		airspeedValue = airspeed / AIR_SPEED_UNIT_IAS;
		airspeedValue &= 0x7FFF;
	}
	result[position++] = airspeedValue >> 8;
	result[position++] = (airspeedValue << 8) >> 8;
	printf("encodeAirSpeed \n");
	printByteArray(result);
	return 2;
}

int encodeGroundVector(double groundSpeed, double aircraftAngle, BYTE* result, int position) {
	short groundSpeedValue = groundSpeed / AIR_SPEED_UNIT_MACH;
	short angleValue = aircraftAngle / MAGNETIC_HEADING_UNIT;
	result[position++] = groundSpeedValue >> 8;
	result[position++] = (groundSpeedValue << 8) >> 8;
	result[position++] = angleValue >> 8;
	result[position++] = (angleValue << 8) >> 8;
	printf("encodeGroundVector \n");
	printByteArray(result);
	return 4;
}

int encodeTargetIdentification(char flightId[], BYTE* result, int position) {
	char temp[9] = { 0 };
	for (int j = 0; flightId[j] != '\0'; j++) {
		temp[j] = flightId[j];
	}
	BYTE tempEncodeResult[8];
	for (int i = 0; i < 8; i++) {
		char c = temp[i];
		if (c == '\0') {
			c = ' ';
		}
		BYTE encode = encodeChar(c);
		tempEncodeResult[i] = encode;
	}
	result[position++] = (tempEncodeResult[0] << 2) | (tempEncodeResult[1] >> 4);
	result[position++] = ((tempEncodeResult[1] & 0x0F) << 4) | ((tempEncodeResult[2] << 2) >> 4);
	result[position++] = (tempEncodeResult[2] << 6) | tempEncodeResult[3];
	result[position++] = (tempEncodeResult[4] << 2) | (tempEncodeResult[5] >> 4);
	result[position++] = ((tempEncodeResult[5] & 0x0F) << 4) | ((tempEncodeResult[6] << 2) >> 4);
	result[position++] = (tempEncodeResult[6] << 6) | tempEncodeResult[7];
	printf("encodeTargetIdentification \n");
	printByteArray(result);
	return 6;
}

BYTE encodeChar(char c) {
	BYTE result = 0;
	if (c == ' ') {
		result = 2 << 4;
	}
	else if (c >= 'A' && c <= 'O') {
		result = c - 'A' + 1;
	}
	else if (c >= 'P' && c <= 'Z') {
		result = (1 << 4) + c - 'P';
	}
	else if (c >= '0' && c <= '9') {
		result = 0x30 + c - '0';
	}
	return result;
}

int encodeEmitterCategory(BYTE emitterCategory, BYTE* result, int position) {
	BYTE cat = 0;
	if (emitterCategory == LIGHT_AIRCRAFT) {
		cat = 1;
	}
	else if (emitterCategory == MEDIUM_AIRCRAFT) {
		cat = 3;
	}
	else if (emitterCategory == ROTOCRAFT) {
		cat = 10;
	}
	else if (emitterCategory == GLIDER) {
		cat = 11;
	}
	else if (emitterCategory == LIGHT_THAN_AIR) {
		cat = 12;
	}
	else if (emitterCategory == PARACHUTIST) {
		cat = 16;
	}
	else if (emitterCategory == ULM_LIGHT) {
		cat = 1;
	}
	else if (emitterCategory == UNMANNED_AERIAL_VEHICLE) {
		cat = 13;
	}
	result[position++] = cat;
	printf("encodeEmitterCategory \n");
	printByteArray(result);
	return 1;
}

void printByteArray(BYTE* bytes) {
	for (int i = 0; i < 100; i++) {
		printf("%x ", bytes[i]);
	}
	printf("\n");
}

