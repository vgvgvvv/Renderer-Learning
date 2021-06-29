#include "Path.h"


#if PLATFORM_WINDOWS
#include <windows.h>
#endif

std::string Path::GetCurrentExeFilePath()
{
    char host_path[MAX_PATH];
#if PLATFORM_WINDOWS
    GetModuleFileName(nullptr, host_path, MAX_PATH);
#else
    auto result = getcwd(host_path, sizeof(host_path));
    assert(result != nullptr);
#endif
    return std::string(host_path);
}

std::string Path::GetCurrentExeDirectory()
{
	std::string f = GetCurrentExeFilePath();
	return f.substr(0, f.find_last_of("\\/"));
}