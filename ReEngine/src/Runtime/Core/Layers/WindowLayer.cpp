#include "WindowLayer.h"


#include "ClassContext.h"
#include "InputSystem.h"
#include "Misc/GlobalContext.h"
#include "GenericWindow.h"

DEFINE_DRIVEN_CLASS_IMP(WindowLayer, Layer)

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

void WindowLayer::OnBeforeRender(float deltaTime)
{
	if (window)
	{
		window->NewFrame();
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
