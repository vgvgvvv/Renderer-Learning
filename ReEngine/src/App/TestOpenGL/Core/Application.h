#pragma once
#include "Layer/Layer.h"
#include "TestOpenGL_API.h"

class TestOpenGL_API Application
{
public:
	int Run();
protected:
	virtual void Init();
	virtual void Uninit();
	virtual bool ShouldQuit();

protected:
	LayerManager LayerManager;
};


