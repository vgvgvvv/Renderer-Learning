#pragma once
#include <string>


#include "yaml-cpp/node/convert.h"
#include "uuid.h"
#include "GlobalAssets_API.h"
#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"
#include "Serialization_API.h"

class Vector3;

class Serialization_API YAMLRead : public IBaseTransfer
{
public:

	YAMLRead(const std::string& filePath) : Root(YAML::Node()), filePath(filePath) {}


	bool IsLoading() const override { return true; }
	bool IsWriting() const override { return false; }
	
	template<class T>
	void transfer(T& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void transfer(uuids::uuid& data, const std::string& name, TransferFlag flag = TransferFlag::None);

private:
	YAML::Node Root;
	std::string filePath;
};



class Serialization_API YAMLWrite : public IBaseTransfer
{
public:

	YAMLWrite(const std::string& filePath) : Root(YAML::Node()), filePath(filePath) {}

	bool IsLoading() const override { return false; }
	bool IsWriting() const override { return true; }
	
	template<class T>
	void transfer(T& data, const std::string& name, TransferFlag flag = TransferFlag::None);
	
	void transfer(uuids::uuid& data, const std::string& name, TransferFlag flag = TransferFlag::None);

	void Save();

private:
	YAML::Node Root;
	std::string filePath;
};
