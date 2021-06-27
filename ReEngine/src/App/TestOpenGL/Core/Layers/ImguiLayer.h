#pragma once
#include "Layer/Layer.h"

class ImguiLayer : public Layer
{
public:
	ImguiLayer() = default;
	~ImguiLayer() = default;
	void OnInit() override;
	void OnShutDown() override;
};
