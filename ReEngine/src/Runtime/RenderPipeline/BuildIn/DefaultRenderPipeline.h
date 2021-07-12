#pragma once
#include "RenderPipeline.h"

class RenderPipeline_API DefaultRenderPipeline : public RenderPipeline
{
public:
	void Render(const RenderContext& context, std::list<Camera*> cameras) override;

private:
	void RenderSingleCamera(const RenderContext& context, Camera* cameras);
};
