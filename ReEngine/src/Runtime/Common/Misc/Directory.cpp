#include "Directory.h"

#include <iostream>
#include <fstream>

bool Directory::GetFiles(const std::string& path, std::list<std::string>& result)
{
	for (const auto& entry : fs::directory_iterator(path))
	{
		
	}
}
