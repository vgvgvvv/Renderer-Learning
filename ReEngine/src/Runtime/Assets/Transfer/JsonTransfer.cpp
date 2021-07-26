#include "JsonTransfer.h"


#include "rapidjson/istreamwrapper.h"
#include "rapidjson/ostreamwrapper.h"
#include "rapidjson/writer.h"


JsonRead::JsonRead(const std::string& filePath) : filePath(filePath)
{
	using namespace rapidjson;
	std::ifstream inputFile(filePath);
	IStreamWrapper isw(inputFile);
	doc.ParseStream(isw);
	inputFile.close();
}


void JsonRead::transfer(bool& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(name.c_str(), name.size());
	
	if(doc.HasMember(key))
	{
		data = doc[key].GetBool();
	}
	else
	{
		data = true;
	}
}

void JsonRead::transfer(int& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	if (doc.HasMember(key))
	{
		data = doc[key].GetInt();
	}
	else
	{
		data = 0;
	}
}

void JsonRead::transfer(float& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	if (doc.HasMember(key))
	{
		data = doc[key].GetFloat();
	}
	else
	{
		data = 0.0f;
	}
}

void JsonRead::transfer(double& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	if (doc.HasMember(key))
	{
		data = doc[key].GetDouble();
	}
	else
	{
		data = 0.0;
	}
}

void JsonRead::transfer(std::string& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	if (doc.HasMember(key))
	{
		data = doc[key].GetString();
	}
	else
	{
		data = "";
	}
}


void JsonRead::transfer(uuids::uuid& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));
	
	const auto str = doc[key].GetString();
	data.from_string(str);
}


JsonWrite::JsonWrite(const std::string& filePath) : filePath(filePath)
{
	doc.SetObject();
}


void JsonWrite::transfer(bool& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	
	key.SetString(rapidjson::StringRef(name));

	rapidjson::Value value;
	value.SetBool(data);

	if (doc.HasMember(key))
	{
		doc.EraseMember(key);
	}
	
	doc.AddMember(key, value, doc.GetAllocator());
}

void JsonWrite::transfer(int& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	rapidjson::Value value;
	value.SetInt(data);

	if (doc.HasMember(key))
	{
		doc.EraseMember(key);
	}
	
	doc.AddMember(key, value, doc.GetAllocator());
}

void JsonWrite::transfer(float& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	rapidjson::Value value;
	value.SetFloat(data);

	if (doc.HasMember(key))
	{
		doc.EraseMember(key);
	}
	
	doc.AddMember(key, value, doc.GetAllocator());
}

void JsonWrite::transfer(double& data, const std::string& name, TransferFlag flag)
{
	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	rapidjson::Value value;
	value.SetDouble(data);

	if (doc.HasMember(key))
	{
		doc.EraseMember(key);
	}
	
	doc.AddMember(key, value, doc.GetAllocator());
}

void JsonWrite::transfer(std::string& data, const std::string& name, TransferFlag flag)
{

	rapidjson::Value key;
	key.SetString(rapidjson::StringRef(name));

	rapidjson::Value value;
	value.SetString(rapidjson::StringRef(data));

	if(doc.HasMember(key))
	{
		doc.EraseMember(key);
	}
	
	doc.AddMember(key, value, doc.GetAllocator());
}

void JsonWrite::transfer(uuids::uuid& data, const std::string& name, TransferFlag flag)
{
	std::string str = to_string(data);
	transfer(str, name, flag);
}

void JsonWrite::Save()
{
	using namespace  rapidjson;

	std::ofstream outputFile(filePath);

	OStreamWrapper osw(outputFile);

	Writer<OStreamWrapper, UTF8<>> writer(osw);

	doc.Accept(writer);
	
	outputFile.close();
	
}
