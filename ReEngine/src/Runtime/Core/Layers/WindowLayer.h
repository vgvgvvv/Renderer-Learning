#pragma once
#include "WindowLayer/OpenGL.h"
#include "Layer/Layer.h"

#include "Core_API.h"

class Core_API WindowLayer : public Layer
{
public:
	WindowLayer() = default;
	~WindowLayer() override = default;
	void OnInit() override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
};
