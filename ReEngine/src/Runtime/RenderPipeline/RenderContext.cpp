#include "RenderContext.h"

#include "Renderer/OpenGLRenderContext.h"
#include "RendererComponents/BaseRenderer.h"

RenderContext::RenderContext()
{
	context = std::make_shared<OpenGLRenderContext>();
}

void RenderContext::Clear(const Color& color)
{
	context->Clear(color);
}


void RenderContext::SetupCameraProperties(const Camera& camera)
{
	// TODO
}

void RenderContext::DrawSkyBox(const Camera& camera)
{
	// TODO
}

void RenderContext::DrawRenderers(const DrawingSetting& drawingSetting, const FilterSetting& filterSetting)
{
	auto& renderers = RendererManager::Get().GetRenderers();

	for (auto renderer : renderers)
	{
		DrawSingleRenderer(renderer, drawingSetting, filterSetting);
	}
}

void RenderContext::DrawSingleRenderer(BaseRenderer* renderer, const DrawingSetting& drawingSetting,
	const FilterSetting& filterSetting)
{
	
}

