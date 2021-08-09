#pragma once
#include "Layer/Layer.h"
#include "InputSystem_API.h"

class InputSystem_API InputLayer : public Layer
{
public:
	void OnInit() override;
	void OnPreUpdate(float deltaTime) override;
	void OnShutDown() override;
};