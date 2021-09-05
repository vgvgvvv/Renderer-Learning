#include "GlfwWindow.h"

#include "CommonAssert.h"
#include "Config/Config.h"
#include "GlewContext.h"
#include "GlfwContext.h"
#include "GlfwInput.h"
#include "ImguiLayer/imgui_impl_glfw.h"
#include "ImguiLayer/imgui_impl_opengl3.h"
#include "InputSystem.h"

DEFINE_DRIVEN_CLASS_IMP(GlfwOpenGLWindow, IGenericWindow)

void GlfwOpenGLWindow::Init()
{
	GlfwInitDesc glfwDesc;

	inifile::IniFile baseSettingIni;
	RE_ASSERT(Config::LoadConfigByName("BaseSetting", &baseSettingIni));
	baseSettingIni.GetIntValue("Window", "Height", &glfwDesc.Height);
	baseSettingIni.GetIntValue("Window", "Width", &glfwDesc.Width);
	baseSettingIni.GetStringValue("Window", "Title", &glfwDesc.Title);

	glfwDesc.RHIType = GlfwRHIType::OpenGL;
	
	GlfwContext::Get().Init(glfwDesc);

	GlewContext::Get().Init();

	InputSystem::Get().SetDevice<GlfwInput>();
}

void GlfwOpenGLWindow::NewFrame()
{
}


void GlfwOpenGLWindow::ImGuiNewFrame()
{
	ImGui_ImplOpenGL3_NewFrame();
	ImGui_ImplGlfw_NewFrame();
}

void GlfwOpenGLWindow::Swap()
{
	static auto& glfw = GlfwContext::Get();
	glfw.SwapBuffer();
	glfw.PollEvents();
}

void GlfwOpenGLWindow::Shutdown()
{
	GlfwContext::Get().ShutDown();
}

bool GlfwOpenGLWindow::ShouldQuit()
{
	if (GlfwContext::Get().ShouldQuit())
	{
		return true;
	}
	return false;
}

DEFINE_DRIVEN_CLASS_IMP(GlfwVulkanWindow, IGenericWindow)

void GlfwVulkanWindow::Init()
{
	GlfwInitDesc glfwDesc;

	inifile::IniFile baseSettingIni;
	RE_ASSERT(Config::LoadConfigByName("BaseSetting", &baseSettingIni));
	baseSettingIni.GetIntValue("Window", "Height", &glfwDesc.Height);
	baseSettingIni.GetIntValue("Window", "Width", &glfwDesc.Width);
	baseSettingIni.GetStringValue("Window", "Title", &glfwDesc.Title);

	glfwDesc.RHIType = GlfwRHIType::Vulkan;

	GlfwContext::Get().Init(glfwDesc);

	InputSystem::Get().SetDevice<GlfwInput>();
}

void GlfwVulkanWindow::NewFrame()
{
}


void GlfwVulkanWindow::ImGuiNewFrame()
{
	// ImGui_ImplOpenGL3_NewFrame();
	// ImGui_ImplGlfw_NewFrame();
}

void GlfwVulkanWindow::Swap()
{
	static auto& glfw = GlfwContext::Get();
	glfw.SwapBuffer();
	glfw.PollEvents();
}

void GlfwVulkanWindow::Shutdown()
{
	GlfwContext::Get().ShutDown();
}

bool GlfwVulkanWindow::ShouldQuit()
{
	if (GlfwContext::Get().ShouldQuit())
	{
		return true;
	}
	return false;
}