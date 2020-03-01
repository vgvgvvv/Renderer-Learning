#pragma once

#include "VertexBuffer.h"
#include "VertexBufferLayout.h"

/**
 * VAO对象
 */
class VertexArrayObject
{
private:
	uint32_t render_id_;
public:
	VertexArrayObject();
	~VertexArrayObject();
	
	void AddBuffer(const VertexBuffer& vb, const VertexBufferLayout& layout);

	void Bind() const;
	void Unbind() const;
};
