#pragma once
#include "ClassInfo.h"
#include "GenericWindow_API.h"

class GenericWindow_API IGenericWindow
{
	DEFINE_CLASS(IGenericWindow)
public:
	virtual ~IGenericWindow() = default;
	virtual void Init() = 0;
	virtual void Swap() = 0;
	virtual void Shutdown() = 0;
};

