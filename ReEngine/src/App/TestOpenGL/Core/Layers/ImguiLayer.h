#pragma once
#include "Layer/Layer.h"

class ImguiLayer : public Layer
{
public:
	ImguiLayer() = default;
	~ImguiLayer() = default;
	void OnInit() override;
	void OnBeforeRender() override;
	void OnRender() override;
	void OnAfterRender() override;
	void OnShutDown() override;
};