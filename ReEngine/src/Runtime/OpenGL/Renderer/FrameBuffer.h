#pragma once
#include <cstdint>

#include "IFrameBuffer.h"
#include "ReOpenGL_API.h"

class ReOpenGL_API FrameBuffer : public IFrameBuffer
{
public:
	FrameBuffer();
	~FrameBuffer() override;

	void Bind() const override;
	void Unbind() const override;

};
