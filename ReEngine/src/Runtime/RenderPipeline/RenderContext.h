#pragma once

#include <memory>

#include "Color.h"
#include "RenderPipeline_API.h"

class OpenGLRenderContext;

class RenderPipeline_API RenderContext
{
public:

	RenderContext();
	
	void Clear(const Color& color);


private:
	std::shared_ptr<OpenGLRenderContext> context;
};
