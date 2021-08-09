#include "WindowLayer.h"


#include "ClassContext.h"
#include "InputSystem.h"
#include "Misc/GlobalContext.h"
#include "GenericWindow.h"

void WindowLayer::OnInit()
{
	auto WindowClassName = GlobalContext::Get().GetStringValue("WindowClassName", "GlfwWindow");
	window = ClassContext::Get().CreateT<IGenericWindow>(WindowClassName);

	if(window)
	{
		window->Init();
	}
}

void WindowLayer::OnPreUpdate(float deltaTime)
{
	InputSystem::Get().Update(deltaTime);
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
