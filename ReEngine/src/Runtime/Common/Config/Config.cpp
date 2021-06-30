#include "Config.h"

#include "Misc/Path.h"

inifile::IniFile Config::LoadConfig(const std::string& config)
{
	inifile::IniFile result;
	result.Load(config);
	return result;
}

inifile::IniFile Config::LoadConfigByName(const std::string& name)
{
	auto tmp = name;
	if(tmp.ends_with(".ini"))
	{
		tmp = tmp + ".ini";
	}
	std::string path = Path::Combine(Path::GetConfigPath(), tmp);
	return LoadConfig(path);
}
