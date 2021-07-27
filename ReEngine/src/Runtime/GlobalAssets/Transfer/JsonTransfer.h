#pragma once
#include <fstream>
#include <string>


#include "BaseTransfer.h"
#include "uuid.h"
#include "TransferFlag.h"
#include "GlobalAssets_API.h"
#include "nlohmann/json.hpp"

class GlobalAssets_API JsonRead : public IBaseTransfer
{
public:

	JsonRead(const std::string& filePath);


	bool IsReading() override { return true; }
	bool IsWriting() override { return false; }

	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		*data = doc[name].get<T>();
	}
	
	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);
	
private:
	std::string filePath;
	nlohmann::json doc;
};

class GlobalAssets_API JsonWrite : public IBaseTransfer
{
public:

	JsonWrite(const std::string& filePath);

	bool IsReading() override { return false; }
	bool IsWriting() override { return true; }

	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		doc[name] = *data;
	}
	
	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);

	void Save();
	
private:
	std::string filePath;
	nlohmann::json doc;
};
