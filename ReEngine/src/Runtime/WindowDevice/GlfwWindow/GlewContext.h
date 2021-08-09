#pragma once

#include "Singleton.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlewContext
{
	DEFINE_SINGLETON(GlewContext);
public:
	bool Init() const;
};