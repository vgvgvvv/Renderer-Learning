#pragma once
#include <cstdint>
#include "ReOpenGL_API.h"

class ReOpenGL_API FrameBuffer
{
public:
	FrameBuffer();
	~FrameBuffer();

	void Bind();
	void Unbind();

private:
	uint32_t render_id_;
};
