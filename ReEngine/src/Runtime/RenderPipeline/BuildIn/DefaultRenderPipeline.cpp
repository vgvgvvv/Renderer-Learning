#include "DefaultRenderPipeline.h"

void DefaultRenderPipeline::Render(const RenderContext& context, std::list<Camera*> cameras)
{
	for (auto camera : cameras)
	{
		RenderSingleCamera(context, camera);
	}
}

void DefaultRenderPipeline::RenderSingleCamera(const RenderContext& context, Camera* cameras)
{
	
}

