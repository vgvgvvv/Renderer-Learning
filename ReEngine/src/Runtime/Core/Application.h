#pragma once
#include "Layer/Layer.h"
#include "Core_API.h"

class Core_API Application
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


