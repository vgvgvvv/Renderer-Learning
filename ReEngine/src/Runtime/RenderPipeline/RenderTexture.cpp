#include "RenderTexture.h"
#include "IRenderDevice.h"
#include "RenderContext.h"

RenderTexture::RenderTexture(int width, int height)
{
	auto& device = RenderContext::Get().GetDevice();
	
	frameBuffer = device.CreateFrameBuffer();
	texture = device.CreateTexture(width, height);

	frameBuffer->SetFrameBufferTexture(*texture);
}
