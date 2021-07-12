#include "RenderContext.h"

#include "Renderer/OpenGLRenderContext.h"

RenderContext::RenderContext()
{
	context = std::make_shared<OpenGLRenderContext>();
}

void RenderContext::Clear(const Color& color)
{
	context->Clear(color);
}


