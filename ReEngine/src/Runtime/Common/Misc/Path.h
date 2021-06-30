#pragma once

#include <string>

class Path
{
public:
	static std::string GetCurrentExeFilePath();
	static std::string GetCurrentExeDirectory();
	static std::string Combine(const std::string& p1, const std::string& p2);
};