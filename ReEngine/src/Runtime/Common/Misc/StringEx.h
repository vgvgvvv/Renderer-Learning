#pragma once
#include <string>

namespace CommonLib
{
    void ReplaceAll(std::string& str, const std::string& from, const std::string& to);
	std::string WStringToString(const std::wstring& str);
	std::wstring StringToWString(const std::string& str);
}
