#pragma once
#include <string>
#include "CommonLib_API.h"

namespace CommonLib
{
	CommonLib_API std::string ReadFileIntoString(const std::string& path);
	CommonLib_API void SaveStringIntoFile(const std::string& content, const std::string& path);
}
