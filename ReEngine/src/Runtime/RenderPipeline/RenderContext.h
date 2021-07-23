#pragma once

#include <memory>

#include "Camera.h"
#include "Color.h"
#include "Singleton.h"
#include "RenderPipeline_API.h"

class IRenderDevice;
class BaseRenderer;
class OpenGLDevice;

struct RenderPipeline_API DrawingSetting
{
	
};

struct RenderPipeline_API FilterSetting
{
	
};


class RenderPipeline_API RenderContext
{
	DEFINE_SINGLETON(RenderContext);
public:

	void Clear(const Color& color);

	void SetupCameraProperties(const Camera& camera);

	void DrawSkyBox(const Camera& camera);

	void DrawRenderers(const DrawingSetting& drawingSetting, const FilterSetting& filterSetting);

	void TestDraw();

	IRenderDevice& GetDevice() const { return *device; }
	void SetDevice(const std::shared_ptr<IRenderDevice>& device) { this->device = device; }

	void ResetState();
	
private:

	void DrawSingleRenderer(BaseRenderer* renderer, const DrawingSetting& drawingSetting, const FilterSetting& filterSetting);

private:
	std::shared_ptr<IRenderDevice> device;
};
