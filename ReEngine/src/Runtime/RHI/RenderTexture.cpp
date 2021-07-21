#include "RenderTexture.h"
#include "IRenderContext.h"

RenderTexture::RenderTexture(IRenderContext& context, int width, int height)
{
	frameBuffer = context.CreateFrameBuffer();
	texture = context.CreateTexture(width, height);

	frameBuffer->SetFrameBufferTexture(*texture);
}
