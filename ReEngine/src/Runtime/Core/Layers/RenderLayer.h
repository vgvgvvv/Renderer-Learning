#pragma once
#include <memory>

#include "RenderPipeline.h"
#include "Layer/Layer.h"

#include "Core_API.h"


class Core_API RenderLayer : public Layer
{
	DEFINE_DRIVEN_CLASS(RenderLayer, Layer)
public:
	RenderLayer(std::shared_ptr<RenderPipeline> pipeline = nullptr);
	void OnInit() override;
	void OnBeforeRender(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;

private:
	std::shared_ptr<RenderPipeline> pipeline;
};
