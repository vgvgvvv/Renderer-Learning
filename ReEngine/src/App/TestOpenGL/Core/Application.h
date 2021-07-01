#pragma once
#include "Layer/Layer.h"
#include "TestOpenGL_API.h"

class TestOpenGL_API Application
{
public:
	int Run();
protected:
	void Init();
	void Uninit();
	bool ShouldQuit();

private:
	LayerManager LayerManager;
};
