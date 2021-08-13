#pragma once
#include "OpenGL.h"
#include "GenericWindow.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlfwWindow : public IGenericWindow
{
	DEFINE_DRIVEN_CLASS(GlfwWindow, IGenericWindow)
public:
	void Init() override;
	void NewFrame() override;
	void ImGuiNewFrame() override;
	void Swap() override;
	void Shutdown() override;
	bool ShouldQuit() override;
};
