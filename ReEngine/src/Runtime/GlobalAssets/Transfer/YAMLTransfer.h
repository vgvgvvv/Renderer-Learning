#pragma once
#include <string>


#include "yaml-cpp/node/convert.h"
#include "uuid.h"
#include "GlobalAssets_API.h"
#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"

class Vector3;

class GlobalAssets_API YAMLRead : public IBaseTransfer
{
public:

	YAMLRead(const std::string& filePath) : Root(YAML::Node()), filePath(filePath) {}


	bool IsLoading() override { return true; }
	bool IsWriting() override { return false; }
	
	template<class T>
	void transfer(T& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid& data, const std::string& name, TransferFlag flag = TransferFlag::None);

private:
	YAML::Node Root;
	std::string filePath;
};



class GlobalAssets_API YAMLWrite : public IBaseTransfer
{
public:

	YAMLWrite(const std::string& filePath) : Root(YAML::Node()), filePath(filePath) {}

	bool IsLoading() override { return false; }
	bool IsWriting() override { return true; }
	
	template<class T>
	void transfer(T& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	
	void transfer(uuids::uuid& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void Save();

private:
	YAML::Node Root;
	std::string filePath;
};
