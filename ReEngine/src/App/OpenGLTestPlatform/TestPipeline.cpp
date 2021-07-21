#include "TestPipeline.h"
#include "RenderContext.h"

void TestPipeline::Render(RenderContext& context, std::list<Camera*> cameras)
{
	for (auto camera : cameras)
	{
		RenderSingleCamera(context, camera);
	}	
}

void TestPipeline::RenderSingleCamera(RenderContext& context, Camera* camera)
{
	context.Clear(Color::blue);
	context.SetupCameraProperties(*camera);

	DrawingSetting drawSetting;
	FilterSetting filterSetting;
	context.DrawRenderers(drawSetting, filterSetting);
}
