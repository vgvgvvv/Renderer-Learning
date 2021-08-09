#pragma once
#include <map>
#include <string>


#include "Singleton.h"
#include "CommonLib_API.h"

class CommonLib_API GlobalContext
{
	DEFINE_SINGLETON(GlobalContext)
public:

	void SetStringValue(const std::string& name, const std::string& value);
	const std::string& GetStringValue(const std::string& name, const std::string& defaultValue = "");

	void SetFloatValue(const std::string& name, float value);
	float GetFloatValue(const std::string& name, float defaultValue = 0);

	void SetIntValue(const std::string& name, int value);
	int GetIntValue(const std::string& name, int defaultValue = 0);

	void SetBoolValue(const std::string& name, bool value);
	int GetBoolValue(const std::string& name, bool defaultValue = false);
	
private:
	std::map<std::string, std::string> stringMap;
	std::map<std::string, float> floatMap;
	std::map<std::string, int> intMap;
	std::map<std::string, bool> boolMap;
};

class CommonLib_API StaticGlobalContextValue
{
public:
	StaticGlobalContextValue(const std::string& name, const std::string& value)
	{
		GlobalContext::Get().SetStringValue(name, value);
	}

	StaticGlobalContextValue(const std::string& name, float value)
	{
		GlobalContext::Get().SetFloatValue(name, value);
	}

	StaticGlobalContextValue(const std::string& name, int value)
	{
		GlobalContext::Get().SetIntValue(name, value);
	}

	StaticGlobalContextValue(const std::string& name, bool value)
	{
		GlobalContext::Get().SetBoolValue(name, value);
	}
};