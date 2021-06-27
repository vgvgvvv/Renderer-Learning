#pragma once
#include "Layer/Layer.h"


class WindowLayer : public Layer
{
public:
	WindowLayer() = default;
	~WindowLayer() = default;
	void OnInit() override;
	void OnAfterRender() override;
	void OnShutDown() override;
};
