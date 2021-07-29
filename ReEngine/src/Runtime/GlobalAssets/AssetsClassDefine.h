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
	\
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc) { TransferAsset(transferFunc); }\
	virtual void TransferJsonWrite(JsonWrite& transfer) { TransferAsset(transfer); }\
	virtual void TransferJsonRead(JsonRead& transfer) { TransferAsset(transfer); }\
	virtual void TransferImGui(ImGuiTransfer& transfer) { TransferAsset(transfer); }\
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
	\
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc) { TransferImportSetting(transferFunc); }\
	virtual void TransferJsonWrite(JsonWrite& transfer) { TransferImportSetting(transfer); }\
	virtual void TransferJsonRead(JsonRead& transfer) { TransferImportSetting(transfer); }\
	virtual void TransferImGui(ImGuiTransfer& transfer) { TransferImportSetting(transfer); }\
private:\
	uuids::uuid uuid;

