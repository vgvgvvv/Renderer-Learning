#include "Application.h"
#include "Common.h"
#include "Layers/WindowLayer.h"
#include "OpenGL.h"


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
	LayerManager.PushLayer(new WindowLayer());
}

void Application::Uninit()
{
	RE_LOG_INFO("Application", "Application::Uninit");
	
}

int Application::Run()
{
	Init();

	while (!ShouldQuit())
	{
		LayerManager.PreUpdate();
		LayerManager.Update();
		LayerManager.LateUpdate();
		LayerManager.Render();
		LayerManager.AfterRender();
	}

	Uninit();
	
	return 0;
}
