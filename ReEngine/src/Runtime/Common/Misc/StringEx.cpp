#include "StringEx.h"

#include <codecvt>

void StringEx::ReplaceAll(std::string& str, const std::string& from, const std::string& to)
{
    if (from.empty())
        return;
    size_t start_pos = 0;
    while ((start_pos = str.find(from, start_pos)) != std::string::npos) {
        str.replace(start_pos, from.length(), to);
        start_pos += to.length(); // In case 'to' contains 'from', like replacing 'x' with 'yx'
    }
}

std::string StringEx::WStringToString(const std::wstring& str)
{
    return std::wstring_convert<std::codecvt_utf8<wchar_t>>().to_bytes(str);
}

std::wstring StringEx::StringToWString(const std::string& str)
{
    return std::wstring_convert<std::codecvt_utf8<wchar_t>>().from_bytes(str);
}

std::vector<std::string> StringEx::Split(const std::string& str, const std::string& delimiter)
{
    std::vector<std::string> result;
    std::string s = str;

    size_t pos = 0;
    std::string token;
    while ((pos = s.find(delimiter)) != std::string::npos) {
        token = s.substr(0, pos);
        result.push_back(token);
        s.erase(0, pos + delimiter.length());
    }
    result.push_back(s);
    return result;
}
