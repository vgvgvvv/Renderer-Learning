#pragma once

#include <memory>

#include "Camera.h"
#include "Color.h"
#include "RenderPipeline_API.h"

class IRenderContext;
class BaseRenderer;
class OpenGLRenderContext;

struct RenderPipeline_API DrawingSetting
{
	
};

struct RenderPipeline_API FilterSetting
{
	
};


class RenderPipeline_API RenderContext
{
public:

	RenderContext();
	
	void Clear(const Color& color);

	void SetupCameraProperties(const Camera& camera);

	void DrawSkyBox(const Camera& camera);

	void DrawRenderers(const DrawingSetting& drawingSetting, const FilterSetting& filterSetting);

	void TestDraw();
	
private:

	void DrawSingleRenderer(BaseRenderer* renderer, const DrawingSetting& drawingSetting, const FilterSetting& filterSetting);

private:
	std::shared_ptr<IRenderContext> context;
};
