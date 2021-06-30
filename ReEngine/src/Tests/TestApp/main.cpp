#include <iostream>


#include "CommonAssert.h"
#include "Config/Config.h"
#include "Misc/Path.h"
#include "inifile.h"

int main()
{
	inifile::IniFile file;
	Config::LoadConfigByName("BasePath", &file);
	std::string result;
	file.GetStringValue("DotNet", "LibName", &result);
	std::cout << "result" << result << std::endl;

	getchar();
	return 0;
}