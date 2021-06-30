#pragma once
#include <string>

#include "inifile.h"

class Config
{
public:
	static bool LoadConfig(const std::string& config, inifile::IniFile* iniFile);
	static bool LoadConfigByName(const std::string& name, inifile::IniFile* iniFile);
};
