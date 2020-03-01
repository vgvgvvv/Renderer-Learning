#pragma once
#include <cstdint>

class IndexBuffer
{
private:
	uint32_t render_id_;
	uint32_t count_;
public:
	IndexBuffer(const uint32_t* data, uint32_t count);
	~IndexBuffer();
	void Bind() const;
	void Unbind() const;

	uint32_t GetCount() const { return count_; }
};
