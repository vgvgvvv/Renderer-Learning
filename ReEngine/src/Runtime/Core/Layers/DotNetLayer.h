#pragma once
#include "Layer/Layer.h"
#include "DotNetLibManager.h"
#include "Core_API.h"

class Core_API DotNetLayer : public Layer
{
public:

	void OnInit() override;
	void OnPreUpdate(float deltaTime) override;
	void OnUpdate(float deltaTime) override;
	void OnLateUpdate(float deltaTime) override;
	void OnBeforeRender(float deltaTime) override;
	void OnGUI(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;

private:
	DotNetLibManager Manager;

	DotNetAssembly::EntryPointFunc OnInitFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnPreUpdateFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnUpdateFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnLateUpdateFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnBeforeRenderFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnGUIFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnRenderFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnAfterRenderFuncPtr = nullptr;
	DotNetAssembly::EntryPointFunc OnShutDownFuncPtr = nullptr;
	
};
