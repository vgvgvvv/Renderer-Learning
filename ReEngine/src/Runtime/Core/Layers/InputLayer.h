#pragma once
#include "Layer/Layer.h"
#include "Core_API.h"

class Core_API InputLayer : public Layer
{
public:
	void OnInit() override;
	void OnPreUpdate(float deltaTime) override;
	void OnShutDown() override;
};