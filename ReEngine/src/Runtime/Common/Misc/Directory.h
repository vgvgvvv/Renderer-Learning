#pragma once
#include <list>
#include <string>

class Directory
{
public:

	static bool GetFiles(const std::string& path, std::list<std::string>& result);
};
