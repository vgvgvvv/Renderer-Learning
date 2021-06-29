#pragma once

#include <string>

class Path
{
public:
	static std::string GetCurrentExeFilePath();
	static std::string GetCurrentExeDirectory();
};