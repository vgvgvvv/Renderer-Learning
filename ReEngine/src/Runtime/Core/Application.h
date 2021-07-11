#pragma once
#include "ApplicationSetting.h"
#include "Layer/Layer.h"
#include "Core_API.h"

class Core_API Application
{
public:
	Application();

	int Run();

	ApplicationSetting& GetSetting() { return Setting; }
	LayerManager& GetLayerManager() { return LayerManager; }
	
	static Application& Get();

private:
	static Application* Instance;
	
protected:
	virtual void Init();
	virtual void Uninit();
	virtual bool ShouldQuit();

protected:
	LayerManager LayerManager;
	ApplicationSetting Setting;
};


