#include "OpenGL.h"
#include "Application.h"
#include "Common.h"
#include "Layers/ImguiLayer.h"
#include "Layers/RenderLayer.h"
#include "Layers/WindowLayer.h"


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
	LayerManager.PushLayer(new RenderLayer());
	LayerManager.PushLayer(new ImguiLayer());
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
		LayerManager.BeforeRender();
		LayerManager.Render();
		LayerManager.AfterRender();
	}

	Uninit();
	
	return 0;
}
