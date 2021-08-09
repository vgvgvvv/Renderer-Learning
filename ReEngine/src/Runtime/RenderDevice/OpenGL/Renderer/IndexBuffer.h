#pragma once
#include <cstdint>

#include "IIndexBuffer.h"
#include "ReOpenGL_API.h"

class ReOpenGL_API IndexBuffer : public IIndexBuffer
{
private:
	uint32_t count_;
public:
	IndexBuffer(const uint32_t* data, uint32_t count);
	~IndexBuffer();
	void Bind() const override;
	void Unbind() const override;

	uint32_t GetCount() const override { return count_; }
};
