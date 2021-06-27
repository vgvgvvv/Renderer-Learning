#pragma once
#include "Layer/Layer.h"


class Application
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
