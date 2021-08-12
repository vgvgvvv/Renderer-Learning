#pragma once
#include "ClassInfo.h"
#include "GenericWindow_API.h"

class GenericWindow_API IGenericWindow
{
	DEFINE_CLASS(IGenericWindow)
public:
	virtual ~IGenericWindow() = default;
	virtual void Init() = 0;
	virtual void NewFrame() = 0;
	virtual void ImGuiNewFrame() = 0;
	virtual void Swap() = 0;
	virtual void Shutdown() = 0;
	virtual bool ShouldQuit() = 0;
};

