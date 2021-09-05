#include "FirstTriangleApplication.h"

#include <iostream>

#include "Layers/WindowLayer.h"
#include "Misc/GlobalContext.h"

void FirstTriangleApplication::Init()
{
	GlobalContext::Get().SetStringValue("WindowClassName", "GlfwVulkanWindow");

	LayerManager.PushLayer(new WindowLayer());
}
