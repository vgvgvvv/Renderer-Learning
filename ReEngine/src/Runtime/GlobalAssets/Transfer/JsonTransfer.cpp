#include "JsonTransfer.h"
#include "Misc/File.h"


JsonRead::JsonRead(const std::string& filePath) : filePath(filePath)
{
	std::ifstream inputFile(filePath);
	doc << inputFile;
	inputFile.close();
}


void JsonRead::transfer(bool* data, const char* name, TransferFlag flag)
{
	*data = doc[name].get<bool>();
}

void JsonRead::transfer(int* data, const char* name, TransferFlag flag)
{
	*data = doc[name].get<int>();
}

void JsonRead::transfer(float* data, const char* name, TransferFlag flag)
{
	*data = doc[name].get<float>();
}

void JsonRead::transfer(double* data, const char* name, TransferFlag flag)
{
	*data = doc[name].get<double>();
}


void JsonRead::transfer(std::string* data, const char* name, TransferFlag flag)
{
	*data = doc[name].get<std::string>();
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


void JsonWrite::transfer(bool* data, const char* name, TransferFlag flag)
{
	doc[name] = *data;
}

void JsonWrite::transfer(int* data, const char* name, TransferFlag flag)
{
	doc[name] = *data;
}

void JsonWrite::transfer(float* data, const char* name, TransferFlag flag)
{
	doc[name] = *data;
}

void JsonWrite::transfer(double* data, const char* name, TransferFlag flag)
{
	doc[name] = *data;
}

void JsonWrite::transfer(std::string* data, const char* name, TransferFlag flag)
{
	
	doc[name] = *data;
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
