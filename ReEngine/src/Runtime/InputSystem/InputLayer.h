#pragma once
#include "Layer/Layer.h"

class InputLayer : public Layer
{
public:
	void OnInit() override;
	void OnPreUpdate(float deltaTime) override;
	void OnShutDown() override;
};