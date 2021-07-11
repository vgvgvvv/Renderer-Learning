#pragma once
#include <cstdint>

class FrameBuffer
{
public:
	FrameBuffer();
	~FrameBuffer();

	void Bind();
	void Unbind();

private:
	uint32_t render_id_;
};
