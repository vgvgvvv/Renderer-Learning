#include "GlfwWindow.h"

#include "CommonAssert.h"
#include "Config/Config.h"
#include "GlewContext.h"
#include "GlfwContext.h"
#include "GlfwInput.h"
#include "InputSystem.h"

DEFINE_DRIVEN_CLASS_IMP(GlfwWindow, IGenericWindow)

void GlfwWindow::Init()
{
	GlfwInitDesc glfwDesc;

	inifile::IniFile baseSettingIni;
	RE_ASSERT(Config::LoadConfigByName("BaseSetting", &baseSettingIni));
	baseSettingIni.GetIntValue("Window", "Height", &glfwDesc.Height);
	baseSettingIni.GetIntValue("Window", "Width", &glfwDesc.Width);
	baseSettingIni.GetStringValue("Window", "Title", &glfwDesc.Title);


	GlfwContext::Get().Init(glfwDesc);

	GlewContext::Get().Init();

	InputSystem::Get().SetDevice<GlfwInput>();
}

void GlfwWindow::Swap()
{
	static auto& glfw = GlfwContext::Get();
	glfw.SwapBuffer();
	glfw.PollEvents();
}

void GlfwWindow::Shutdown()
{
	GlfwContext::Get().ShutDown();
}

bool GlfwWindow::ShouldQuit()
{
	if (GlfwContext::Get().ShouldQuit())
	{
		return true;
	}
	return false;
}
