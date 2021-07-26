
#include <fstream>

#include "rapidjson/document.h"
#include "rapidjson/ostreamwrapper.h"
#include "rapidjson/rapidjson.h"
#include "rapidjson/writer.h"

using namespace rapidjson;

int main()
{
	Document doc;

	doc.SetObject();
	
	std::string name("name");
	std::string data("data");
	
	Value key;
	key.SetString(rapidjson::StringRef(name));

	Value value;
	value.SetString(rapidjson::StringRef(data));

	if (doc.HasMember(key))
	{
		doc.EraseMember(key);
	}

	doc.AddMember(key, value, doc.GetAllocator());

	std::ofstream outputFile("D:/test.json");

	OStreamWrapper osw(outputFile);

	Writer<OStreamWrapper, UTF8<>> writer(osw);

	doc.Accept(writer);

	outputFile.close();
	
	
	return 0;
}