#pragma once
#include "Layer/Layer.h"
#include "DotNetLibManager.h"

class DotNetLayer : public Layer
{
public:

	void OnInit() override;
	void OnPreUpdate() override;
	void OnUpdate() override;
	void OnLateUpdate() override;
	void OnBeforeRender() override;
	void OnRender() override;
	void OnAfterRender() override;
	void OnShutDown() override;

private:
	DotNetLibManager Manager;
	std::unordered_map<std::string, DotNetAssembly*> assemblies;
};
