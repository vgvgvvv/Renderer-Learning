#pragma once


// 用于定义可以从文件中加载的类

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
