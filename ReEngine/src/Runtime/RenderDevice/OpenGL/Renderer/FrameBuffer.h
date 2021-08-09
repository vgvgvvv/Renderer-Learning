#pragma once
#include <cstdint>

#include "IFrameBuffer.h"
#include "ReOpenGL_API.h"

class ITexture;

class ReOpenGL_API FrameBuffer : public IFrameBuffer
{
public:
	FrameBuffer();
	~FrameBuffer() override;

	void Bind() const override;
	void Unbind() const override;

	void SetFrameBufferTexture(const ITexture& texture) override;
	
};
