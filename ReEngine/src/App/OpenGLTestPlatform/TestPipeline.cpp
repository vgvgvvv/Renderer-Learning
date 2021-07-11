#include "TestPipeline.h"

void TestPipeline::Render(const RenderContext& context, std::list<Camera*> cameras)
{
	for (auto camera : cameras)
	{
		RenderSingleCamera(context, camera);
	}	
}

void TestPipeline::RenderSingleCamera(const RenderContext& context, Camera* camera)
{
	
}
