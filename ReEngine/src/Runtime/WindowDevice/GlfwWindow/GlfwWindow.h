#pragma once
#include "OpenGL.h"
#include "GenericWindow.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlfwOpenGLWindow : public IGenericWindow
{
	DEFINE_DRIVEN_CLASS(GlfwOpenGLWindow, IGenericWindow)
public:
	void Init() override;
	void NewFrame() override;
	void ImGuiNewFrame() override;
	void Swap() override;
	void Shutdown() override;
	bool ShouldQuit() override;
};

class GlfwWindow_API GlfwVulkanWindow : public IGenericWindow
{
	DEFINE_DRIVEN_CLASS(GlfwVulkanWindow, IGenericWindow)
public:
	void Init() override;
	void NewFrame() override;
	void ImGuiNewFrame() override;
	void Swap() override;
	void Shutdown() override;
	bool ShouldQuit() override;
};
