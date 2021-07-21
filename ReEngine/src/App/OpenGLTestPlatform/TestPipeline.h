#pragma once
#include "RenderPipeline.h"

class TestPipeline : public RenderPipeline
{
public:
	void Render(RenderContext& context, std::list<Camera*> cameras) override;

private:
	void RenderSingleCamera(RenderContext& context, Camera* camera);
};
