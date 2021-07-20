#pragma once
#include <cstdint>

#include "IVertexBuffer.h"
#include "ReOpenGL_API.h"

class ReOpenGL_API VertexBuffer : public IVertexBuffer
{

public:

	VertexBuffer(const void* data, uint32_t size);
	~VertexBuffer() override;
	void Bind() const override;
	void Unbind() const override;
};
