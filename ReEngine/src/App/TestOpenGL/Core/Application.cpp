#include "OpenGL.h"
#include "Application.h"
#include "Common.h"
#include "Layers/DotNetLayer.h"
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
	LayerManager.PushLayer(new DotNetLayer());
}

void Application::Uninit()
{
	RE_LOG_INFO("Application", "Application::Uninit");
}

int Application::Run()
{
	Init();

	auto lastTick = std::chrono::system_clock::now();
	std::chrono::duration<double> dt(0);
	while (!ShouldQuit())
	{
		dt = std::chrono::system_clock::now() - lastTick;
		lastTick = std::chrono::system_clock::now();

		const auto deltaTime = 
			std::chrono::duration_cast<std::chrono::milliseconds>(dt).count() * 1.0f / 1000.0f;
		
		LayerManager.PreUpdate(deltaTime);
		LayerManager.Update(deltaTime);
		LayerManager.LateUpdate(deltaTime);
		LayerManager.BeforeRender(deltaTime);
		LayerManager.OnGUI(deltaTime);
		LayerManager.Render(deltaTime);
		LayerManager.AfterRender(deltaTime);
	}

	Uninit();
	
	return 0;
}
