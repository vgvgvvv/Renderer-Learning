#include "Application.h"
#include "Common.h"
#include "OpenGL.h"
#include "Render/RenderLoop.h"
#include "Render/TestRenderPipeline.h"

#include "Renderer/OpenGLRenderContext.h"


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
	GlfwInitDesc glfwDesc;
	GlfwContext::Get().Init(glfwDesc);
	GladContext::Get().Init();
}

void Application::Update()
{
	
	
	
}

void Application::Uninit()
{
	RE_LOG_INFO("Application", "Application::Uninit");
	GlfwContext::Get().ShutDown();
}

int Application::Run()
{
	Init();

	auto& glfw = GlfwContext::Get();

	RenderLoop renderLoop;
	
	while (!ShouldQuit())
	{
		Update();

		renderLoop.Update();

		glfw.SwapBuffer();
		glfw.PollEvents();
	}

	Uninit();
	
	return 0;
}
