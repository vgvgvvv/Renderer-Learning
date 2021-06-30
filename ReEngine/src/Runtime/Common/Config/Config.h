#pragma once
#include <string>

#include "inifile.h"

class Config
{
public:
	static inifile::IniFile LoadConfig(const std::string& config);
	static inifile::IniFile LoadConfigByName(const std::string& name);
};
