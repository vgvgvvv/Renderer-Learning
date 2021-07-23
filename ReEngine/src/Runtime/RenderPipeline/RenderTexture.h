#pragma once

#include <memory>


#include "IFrameBuffer.h"
#include "RenderPipeline_API.h"

class IRenderDevice;

class RenderPipeline_API RenderTexture
{
public:
	RenderTexture(int width, int height);

	ITexture& GetTexture() const { return *texture; }
	IFrameBuffer& GetFrameBuffer() const { return *frameBuffer; }

	void ReSize(int width, int height);

private:
	std::shared_ptr<IFrameBuffer> frameBuffer;
	std::shared_ptr<ITexture> texture;
};
