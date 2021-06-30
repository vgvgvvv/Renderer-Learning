#pragma once
#include "Layer/Layer.h"

class RenderLayer : public Layer
{
public:
	void OnInit() override;
	void OnBeforeRender(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
};
