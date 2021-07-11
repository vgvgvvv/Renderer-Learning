#pragma once
#include <string>
#include "CommonLib_API.h"

namespace CommonLib
{
    CommonLib_API void ReplaceAll(std::string& str, const std::string& from, const std::string& to);
	CommonLib_API std::string WStringToString(const std::wstring& str);
	CommonLib_API std::wstring StringToWString(const std::string& str);
}
