#pragma once
#include <fstream>
#include <string>

#include "uuid.h"
#include "TransferFlag.h"
#include "GlobalAssets_API.h"
#include "nlohmann/json.hpp"

class GlobalAssets_API JsonRead
{
public:

	JsonRead(const std::string& filePath);

	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(double* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);
	
private:
	std::string filePath;
	nlohmann::json doc;
};

class GlobalAssets_API JsonWrite
{
public:

	JsonWrite(const std::string& filePath);

	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(double* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);

	void Save();
	
private:
	std::string filePath;
	nlohmann::json doc;
};
