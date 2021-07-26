#pragma once
#include <fstream>
#include <string>

#include "rapidjson/document.h"
#include "uuid.h"
#include "rapidjson/rapidjson.h"
#include "TransferFlag.h"
#include "Assets_API.h"

class Assets_API JsonRead
{
public:

	JsonRead(const std::string& filePath);

	void transfer(bool& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(int& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(float& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(double& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	
private:
	std::string filePath;
	rapidjson::Document doc;
};

class Assets_API JsonWrite
{
public:

	JsonWrite(const std::string& filePath);

	void transfer(bool& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(int& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(float& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(double& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void Save();
	
private:
	std::string filePath;
	rapidjson::Document doc;
};
