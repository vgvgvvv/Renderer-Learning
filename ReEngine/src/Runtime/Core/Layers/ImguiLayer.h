#pragma once
#include "Layer/Layer.h"
#include "Core_API.h"

class Core_API ImguiLayer : public Layer
{
	DEFINE_DRIVEN_CLASS(ImguiLayer, Layer)
public:
	ImguiLayer() = default;
	~ImguiLayer() = default;
	void OnInit() override;
	void OnBeforeRender(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
};
