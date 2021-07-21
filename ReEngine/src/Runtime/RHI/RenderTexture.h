#pragma once

#include <memory>


#include "IFrameBuffer.h"
#include "RHI_API.h"

class IRenderContext;

class RHI_API RenderTexture
{
public:
	RenderTexture(IRenderContext& context, int width, int height);

	ITexture& GetTexture() const { return *texture; }
	IFrameBuffer& GetFrameBuffer() const { return *frameBuffer; }

private:
	std::shared_ptr<IFrameBuffer> frameBuffer;
	std::shared_ptr<ITexture> texture;
};
