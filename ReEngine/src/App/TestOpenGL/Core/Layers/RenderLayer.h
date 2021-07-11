#pragma once
#include <memory>

#include "RenderPipeline.h"
#include "Layer/Layer.h"

#include "TestOpenGL_API.h"


class TestOpenGL_API RenderLayer : public Layer
{
public:
	void OnInit() override;
	void OnBeforeRender(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;

private:
	std::shared_ptr<RenderPipeline> pipeline;
	std::shared_ptr<RenderContext> renderContext;
};
