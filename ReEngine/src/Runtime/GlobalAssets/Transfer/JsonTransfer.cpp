#include "JsonTransfer.h"
#include "Misc/File.h"


JsonRead::JsonRead(const std::string& filePath) : filePath(filePath)
{
	std::ifstream inputFile(filePath);
	doc << inputFile;
	inputFile.close();
}

void JsonRead::transfer(uuids::uuid* data, const char* name, TransferFlag flag)
{
	const auto str = doc[name].get<std::string>();
	data->from_string(str);
}

JsonWrite::JsonWrite(const std::string& filePath) : filePath(filePath)
{
	doc = {};
}

void JsonWrite::transfer(uuids::uuid* data, const char* name, TransferFlag flag)
{
	doc[name] = to_string(*data);
}

void JsonWrite::Save()
{
	std::ofstream outputFile(filePath);
	outputFile << doc;
	outputFile.close();
}
