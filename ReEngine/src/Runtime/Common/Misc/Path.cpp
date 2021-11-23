#include "Path.h"
#include "Misc/StringEx.h"

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

std::string Path::Combine(const std::string& p1, const std::string& p2)
{
	if(p1.empty())
	{
        return p2;
	}
	if(p2.empty())
	{
        return p1;
	}
    char sep = '/';
    std::string tmp = p1;

#ifdef PLATFORM_WINDOWS
    sep = '\\';
    StringEx::ReplaceAll(tmp, "/", "\\");
#endif
	

    if (tmp[tmp.length()-1] != sep) { // Need to add a
        tmp += sep;                // path separator
        return(tmp + p2);
    }
    else
        return(p1 + p2);
}

std::string Path::GetEngineRootPath()
{
    return Combine(GetCurrentExeDirectory(), "../../../..");
}

std::string Path::GetBinaryPath()
{
    return Combine(GetEngineRootPath(), "binary");
}

std::string Path::GetBinaryBinPath()
{
    return Combine(GetEngineRootPath(), "binary/bin");
}

std::string Path::GetBinaryLibPath()
{
    return Combine(GetEngineRootPath(), "binary/lib");
}

std::string Path::GetExternalPath()
{
    return Combine(GetEngineRootPath(), "external");
}

std::string Path::GetDotnetSourcePath()
{
    return Combine(GetEngineRootPath(), "dotnet");
}

std::string Path::GetSourcePath()
{
    return Combine(GetEngineRootPath(), "src");
}

std::string Path::GetConfigPath()
{
    return Combine(GetEngineRootPath(), "config");
}

std::string Path::GetResourcesPath()
{
    return Combine(GetEngineRootPath(), "resources");
}

std::string Path::GetDotNetBinaryPath()
{
    return Path::Combine(GetBinaryPath(), "dotnet");
}

std::string Path::GetShaderSourcePath()
{
    return Path::Combine(GetSourcePath(), "Shader");
}

std::string Path::GetProjectPath()
{
    return projectPath;
}


std::string Path::projectPath;

void Path::SetProjectPath(const std::string& path)
{
    projectPath = path;
}

std::string Path::GetProjectAssetsPath()
{
    return Combine(GetProjectPath(), "Assets");
}

std::string Path::GetUniquePath(const std::string& path)
{
    return path;
}

