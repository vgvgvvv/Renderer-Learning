#include "WindowLayer.h"

#include "Common.h"
#include "Config/Config.h"
#include "GlfwInput.h"
#include "InputSystem.h"
#include "Misc/GlobalContext.h"

void WindowLayer::OnInit()
{
	auto& WindowClassName = GlobalContext::Get().GetStringValue("WindowClassName", "GlfwWindow");
	window = ClassContext::Get().CreateT<IGenericWindow>(WindowClassName);

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


bool WindowLayer::ShouldQuit()
{
	if(window)
	{
		return window->ShouldQuit();
	}
	return false;
}
