#include "Config.h"

#include "Misc/Path.h"

bool Config::LoadConfig(const std::string& config, inifile::IniFile* iniFile)
{
	iniFile->Load(config);
	if(iniFile->GetErrMsg() != "")
	{
		return false;
	}
	return true;
}

bool Config::LoadConfigByName(const std::string& name, inifile::IniFile* iniFile)
{
	auto tmp = name;
	if(!tmp.ends_with(".ini"))
	{
		tmp = tmp + ".ini";
	}
	std::string path = Path::Combine(Path::GetConfigPath(), tmp);
	return LoadConfig(path, iniFile);
}
