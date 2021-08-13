#pragma once
#include "World.h"
#include "Layer/Layer.h"

#include "Core_API.h"

class Core_API WorldLayer : public Layer
{
	DEFINE_DRIVEN_CLASS(WorldLayer, Layer)
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
};
