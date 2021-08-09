#pragma once
#include "GenericWindow.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlfwWindow : public IGenericWindow
{
	DEFINE_DRIVEN_CLASS(GlfwWindow, IGenericWindow)
public:
	void Init() override;
	void Swap() override;
	void Shutdown() override;
};
