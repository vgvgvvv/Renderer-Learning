#pragma once
#include <memory>

#include "OpenGL.h"
#include "Layer/Layer.h"

#include "Core_API.h"
#include "GenericWindow.h"

class Core_API WindowLayer : public Layer
{
public:
	WindowLayer() = default;
	~WindowLayer() override = default;
	void OnInit() override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
	bool ShouldQuit() override;
private:
	std::shared_ptr<IGenericWindow> window;
};
