#pragma once

#include "uuid.h"

// 用于定义可以从文件中加载的类

#define DEFINE_NORMAL_ASSET_CLASS(className) \
public:\
	template<class T>\
	friend class NormalAssetLoader;\
	const uuids::uuid& Uuid() { return uuid; }\
	static std::shared_ptr<className> CreateDefault(const std::string& filePath);\
	template<class TransferFunction>\
	void TransferAsset(TransferFunction& transferFunc);\
private:\
	uuids::uuid uuid;


#define DEFINE_IMPORT_ASSET_CLASS(className)\
public:\
	template<class T>\
	friend class ImportAssetLoader;\
	const uuids::uuid& Uuid() { return uuid; }\
	static std::shared_ptr<className> CreateDefault(const std::string& filePath);\
	static std::shared_ptr<className> Load(const std::string& filePath);\
	template<class TransferFunction>\
	void TransferImportSetting(TransferFunction& transferFunc);\
private:\
	uuids::uuid uuid;

