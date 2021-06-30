#include "StringEx.h"

#include <codecvt>

void CommonLib::ReplaceAll(std::string& str, const std::string& from, const std::string& to)
{
    if (from.empty())
        return;
    size_t start_pos = 0;
    while ((start_pos = str.find(from, start_pos)) != std::string::npos) {
        str.replace(start_pos, from.length(), to);
        start_pos += to.length(); // In case 'to' contains 'from', like replacing 'x' with 'yx'
    }
}

std::string CommonLib::WStringToString(const std::wstring& str)
{
    return std::wstring_convert<std::codecvt_utf8<wchar_t>>().to_bytes(str);
}

std::wstring CommonLib::StringToWString(const std::string& str)
{
    return std::wstring_convert<std::codecvt_utf8<wchar_t>>().from_bytes(str);
}
