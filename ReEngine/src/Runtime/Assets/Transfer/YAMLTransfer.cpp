#include "YAMLTransfer.h"

#include <fstream>


#include "yaml-cpp/yaml.h"

template <class T>
void YAMLRead::transfer(T& data, const std::string& name, TransferFlag flag)
{
	data = Root[name].as<T>();
}

void YAMLRead::transfer(uuids::uuid& data, const std::string& name, TransferFlag flag)
{
	const auto uuidStr = Root[name].as<std::string>();
	auto uuid = uuids::uuid();
	uuid.from_string(uuidStr);
	data = uuid;
}


template <class T>
void YAMLWrite::transfer(T& data, const std::string& name, TransferFlag flag)
{
	Root[name] = data;
}

void YAMLWrite::transfer(uuids::uuid& data, const std::string& name, TransferFlag flag)
{
	Root[name] = to_string(data);
}

void YAMLWrite::Save()
{
	std::ofstream yamlFile;
	yamlFile.open("example.txt");
	yamlFile << YAML::Dump(Root);
	yamlFile.close();
}
