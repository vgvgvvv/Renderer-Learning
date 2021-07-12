#include "WindowLayer.h"

#include "Common.h"
#include "Config/Config.h"

void WindowLayer::OnInit()
{
	
	GlfwInitDesc glfwDesc;
	
	inifile::IniFile baseSettingIni;
	RE_ASSERT(Config::LoadConfigByName("BaseSetting", &baseSettingIni));
	baseSettingIni.GetIntValue("Window", "Height", &glfwDesc.Height);
	baseSettingIni.GetIntValue("Window", "Width", &glfwDesc.Width);
	baseSettingIni.GetStringValue("Window", "Title", &glfwDesc.Title);


	GlfwContext::Get().Init(glfwDesc);

	GlewContext::Get().Init();

}


void WindowLayer::OnAfterRender(float deltaTime)
{
	static auto& glfw = GlfwContext::Get();
	glfw.SwapBuffer();
	glfw.PollEvents();
}

void WindowLayer::OnShutDown()
{
	GlfwContext::Get().ShutDown();
}
