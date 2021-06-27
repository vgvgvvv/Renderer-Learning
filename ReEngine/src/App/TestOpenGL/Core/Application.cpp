#include "Application.h"
#include "Common.h"
#include "GlfwContext.h"


bool Application::ShouldQuit()
{
	if(GlfwContext::Get().ShouldQuit())
	{
		return true;
	}

	return false;
}

void Application::Init()
{
	RE_LOG_INFO("Application", "Application::Init");
	auto& glfw = GlfwContext::Get();
	GlfwInitDesc glfwDesc;
	glfw.Init(glfwDesc);
}

void Application::Update()
{
	auto& glfw = GlfwContext::Get();

	
	
	glfw.SwapBuffer();
	glfw.PollEvents();
}

void Application::Uninit()
{
	RE_LOG_INFO("Application", "Application::Uninit");
	GlfwContext::Get().ShutDown();
}

int Application::Run()
{
	Init();

	while (!ShouldQuit())
	{
		Update();
	}

	Uninit();
	
	return 0;
}
