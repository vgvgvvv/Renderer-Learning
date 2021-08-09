#pragma once
#include <map>
#include <string>


#include "Singleton.h"
#include "CommonLib_API.h"
#include "Logging/Log.h"

class CommonLib_API GlobalContext
{
	DEFINE_SINGLETON(GlobalContext)
public:

	void SetStringValue(const std::string& name, std::string value);
	std::string GetStringValue(const std::string& name, std::string defaultValue = "");

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

	StaticGlobalContextValue(const std::string& name, const char* value)
	{
		RE_LOG_INFO("Common", "SetValue {0} : {1}", name.c_str(), value);
		std::string str(value);
		GlobalContext::Get().SetStringValue(name, str);
	}
	
	StaticGlobalContextValue(const std::string& name, const std::string& value)
	{
		RE_LOG_INFO("Common", "SetValue {0} : {1}", name.c_str(), value.c_str());
		GlobalContext::Get().SetStringValue(name, value);
	}

	StaticGlobalContextValue(const std::string& name, float value)
	{
		RE_LOG_INFO("Common", "SetValue {0} : {1}", name.c_str(), value);
		GlobalContext::Get().SetFloatValue(name, value);
	}

	StaticGlobalContextValue(const std::string& name, int value)
	{
		RE_LOG_INFO("Common", "SetValue {0} : {1}", name.c_str(), value);
		GlobalContext::Get().SetIntValue(name, value);
	}

	StaticGlobalContextValue(const std::string& name, bool value)
	{
		RE_LOG_INFO("Common", "SetValue {0} : {1}", name.c_str(), value);
		GlobalContext::Get().SetBoolValue(name, value);
	}
};