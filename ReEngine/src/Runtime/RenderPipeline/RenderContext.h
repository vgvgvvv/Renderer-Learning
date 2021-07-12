#pragma once

#include <memory>

#include "Camera.h"
#include "Color.h"
#include "RenderPipeline_API.h"

class OpenGLRenderContext;

class RenderPipeline_API RenderContext
{
public:

	RenderContext();
	
	void Clear(const Color& color);

	void SetupCameraProperties(const Camera& camera);

	void DrawSkyBox(const Camera& camera);


private:
	std::shared_ptr<OpenGLRenderContext> context;
};
