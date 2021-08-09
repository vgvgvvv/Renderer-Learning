#pragma once
#include "GenericWindow.h"
#include "Win32Windows_API.h"

class Win32Windows_API Win32Window : public IGenericWindow
{
	DEFINE_DRIVEN_CLASS(Win32Window, IGenericWindow)
public:
	void Init() override;
	void Swap() override;
	void Shutdown() override;
};
