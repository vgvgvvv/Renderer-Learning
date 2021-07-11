#include "ApplicationAPI.h"
#include "Application.h"
#include "ApplicationSetting.h"
#include <string>
#include "portable-file-dialogs.h"
#include "Common.h"

const char* ApplicationAPI::GetProjectRoot()
{
	return Application::Get().GetSetting().CurrentProjectRoot.c_str();
}

void ApplicationAPI::SetProjectRoot(const char* Root)
{
	Application::Get().GetSetting().CurrentProjectRoot = Root;
}

void ApplicationAPI::SelectProjectRoot()
{
	auto dir = pfd::select_folder("Select Project", ".").result();
	if(dir != "")
	{
		RE_LOG_INFO("Application", "Selected Project Root : {}", dir.c_str());
		SetProjectRoot(dir.c_str());
	}
}
