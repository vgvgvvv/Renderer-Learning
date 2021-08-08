#include "TestPipeline.h"

#include "Misc/Path.h"
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
	context.Clear(Color::gray);
	context.SetupCameraProperties(*camera);

	// context.TestDraw(*camera);
	
	DrawingSetting drawSetting;
	FilterSetting filterSetting;
	context.DrawRenderers(camera, drawSetting, filterSetting);
	
}
