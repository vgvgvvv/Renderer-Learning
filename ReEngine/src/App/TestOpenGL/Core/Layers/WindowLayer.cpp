#include "WindowLayer.h"
#include "OpenGL.h"

void WindowLayer::OnInit()
{
	GlfwInitDesc glfwDesc;
	GlfwContext::Get().Init(glfwDesc);
	GladContext::Get().Init();
}


void WindowLayer::OnAfterRender()
{
	static auto& glfw = GlfwContext::Get();
	glfw.SwapBuffer();
	glfw.PollEvents();
}

void WindowLayer::OnShutDown()
{
	GlfwContext::Get().ShutDown();
}
