#include "WindowLayer.h"

#include "Common.h"
#include "Config/Config.h"
#include "GlfwInput.h"
#include "InputSystem.h"

void WindowLayer::OnInit()
{
	window = ClassContext::Get().CreateT<IGenericWindow>("GlfwWindow");

	if(window)
	{
		window->Init();
	}
}


void WindowLayer::OnAfterRender(float deltaTime)
{
	if (window)
	{
		window->Swap();
	}
}

void WindowLayer::OnShutDown()
{
	if (window)
	{
		window->Shutdown();
	}
}
