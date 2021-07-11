#pragma once
#include "OpenGL.h"
#include "Layer/Layer.h"

#include "TestOpenGL_API.h"

class TestOpenGL_API WindowLayer : public Layer
{
public:
	WindowLayer() = default;
	~WindowLayer() override = default;
	void OnInit() override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
};
