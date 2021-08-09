#include "GlobalContext.h"

void GlobalContext::InitSingleton()
{
	
}

void GlobalContext::SetStringValue(const std::string& name, std::string value)
{
	stringMap.insert_or_assign(name, value);
}

std::string GlobalContext::GetStringValue(const std::string& name, std::string defaultValue)
{
	if(stringMap.contains(name))
	{
		return stringMap.at(name);
	}
	return defaultValue;
}

void GlobalContext::SetFloatValue(const std::string& name, float value)
{
	floatMap.insert_or_assign(name, value);
}

float GlobalContext::GetFloatValue(const std::string& name, float defaultValue)
{
	if (floatMap.contains(name))
	{
		return floatMap.at(name);
	}
	return defaultValue;
}

void GlobalContext::SetIntValue(const std::string& name, int value)
{
	intMap.insert_or_assign(name, value);
}

int GlobalContext::GetIntValue(const std::string& name, int defaultValue)
{
	if (intMap.contains(name))
	{
		return intMap.at(name);
	}
	return defaultValue;
}

void GlobalContext::SetBoolValue(const std::string& name, bool value)
{
	boolMap.insert_or_assign(name, value);
}

int GlobalContext::GetBoolValue(const std::string& name, bool defaultValue)
{
	if (boolMap.contains(name))
	{
		return boolMap.at(name);
	}
	return defaultValue;
}
