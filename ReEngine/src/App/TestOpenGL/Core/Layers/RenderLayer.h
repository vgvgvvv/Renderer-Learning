#pragma once
#include "Layer/Layer.h"

class RenderLayer : public Layer
{
public:
	void OnInit() override;
	void OnBeforeRender() override;
	void OnRender() override;
	void OnAfterRender() override;
	void OnShutDown() override;
};
