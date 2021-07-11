#include "ApplicationAPI.h"
#include "Application.h"
#include "ApplicationSetting.h"
#include <string>

const char* ApplicationAPI::GetProjectRoot()
{
	return Application::Get().GetSetting().CurrentProjectRoot.c_str();
}

void ApplicationAPI::SetProjectRoot(const char* Root)
{
	Application::Get().GetSetting().CurrentProjectRoot = Root;
}
