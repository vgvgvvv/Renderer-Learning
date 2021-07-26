#pragma once
#include <fstream>
#include <string>

#include "rapidjson/document.h"
#include "uuid.h"
#include "rapidjson/rapidjson.h"
#include "TransferFlag.h"
#include "GlobalAssets_API.h"

class GlobalAssets_API JsonRead
{
public:

	JsonRead(const std::string& filePath);

	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(double* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(const char** data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);
	
private:
	std::string filePath;
	rapidjson::Document doc;
};

class GlobalAssets_API JsonWrite
{
public:

	JsonWrite(const std::string& filePath);

	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(double* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(const char** data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);

	void Save();
	
private:
	std::string filePath;
	rapidjson::Document doc;
};
