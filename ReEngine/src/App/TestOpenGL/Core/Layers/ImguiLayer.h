#pragma once
#include "Layer/Layer.h"

#include "TestOpenGL_API.h"

class TestOpenGL_API ImguiLayer : public Layer
{
public:
	ImguiLayer() = default;
	~ImguiLayer() = default;
	void OnInit() override;
	void OnBeforeRender(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
};
