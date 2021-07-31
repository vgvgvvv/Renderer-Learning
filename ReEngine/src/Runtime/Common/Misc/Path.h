#pragma once

#include <string>
#include "CommonLib_API.h"

class CommonLib_API Path
{
public:
	static std::string GetCurrentExeFilePath();
	static std::string GetCurrentExeDirectory();
	static std::string Combine(const std::string& p1, const std::string& p2);

	static std::string GetEngineRootPath();
	static std::string GetBinaryPath();
	static std::string GetBinaryBinPath();
	static std::string GetBinaryLibPath();
	static std::string GetExternalPath();
	static std::string GetDotnetSourcePath();
	static std::string GetSourcePath();
	static std::string GetConfigPath();
	static std::string GetResourcesPath();
	static std::string GetDotNetBinaryPath();
	static std::string GetShaderSourcePath();

	static std::string GetProjectPath();
	static void SetProjectPath(const std::string& path);
	static std::string GetProjectAssetsPath();

	static std::string GetUniquePath(const std::string& path);

private:
	static std::string projectPath;
};