#include "DefaultRenderPipeline.h"

#include "RenderTexture.h"

void DefaultRenderPipeline::Render(RenderContext& context, std::list<Camera*> cameras)
{
	for (auto camera : cameras)
	{
		RenderSingleCamera(context, camera);
	}
}

void DefaultRenderPipeline::RenderSingleCamera(RenderContext& context, Camera* camera)
{
	context.SetupCameraProperties(*camera);

	context.Clear(Color::gray);

	DrawingSetting drawSetting;
	FilterSetting filterSetting;
	context.DrawRenderers(camera, drawSetting, filterSetting);

	context.ResetState();
}

