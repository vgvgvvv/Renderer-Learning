#pragma once


// ���ڶ�����Դ��ļ��м��ص���

#define DEFINE_IMPORT_ASSET_CLASS() \
public:\
	const uuids::uuid& Uuid() { return uuid; }\
private:\
	uuids::uuid uuid;

#define DEFINE_NORMAL_ASSET_CLASS()\
public:\
	const uuids::uuid& Uuid() { return uuid; }\
private:\
	uuids::uuid uuid;
