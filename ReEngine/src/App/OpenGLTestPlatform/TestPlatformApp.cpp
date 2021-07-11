#include "TestPlatformApp.h"

#include "Core/Layers/WindowLayer.h"
#include "ThirdPart/GlfwContext.h"

void TestPlatformApp::Init()
{
	LayerManager.PushLayer(new WindowLayer());
}

void TestPlatformApp::Uninit()
{
}

bool TestPlatformApp::ShouldQuit()
{
	if (GlfwContext::Get().ShouldQuit())
	{
		return true;
	}

	return false;
}
