#pragma once
#include <cstdint>

#include "ReOpenGL_API.h"

class ReOpenGL_API VertexBuffer
{
private:
	uint32_t render_id_;
public:

	VertexBuffer(const void* data, uint32_t size);
	~VertexBuffer();
	void Bind() const;
	void Unbind() const;
};
