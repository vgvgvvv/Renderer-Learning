#pragma once

#include "IVertexArrayObject.h"
#include "VertexBuffer.h"
#include "VertexBufferLayout.h"
#include "ReOpenGL_API.h"

/**
 * VAO对象
 */
class ReOpenGL_API VertexArrayObject : public IVertexArrayObject
{
public:
	VertexArrayObject();
	~VertexArrayObject() override;
	
	void AddBuffer(const VertexBuffer& vb, const VertexBufferLayout& layout);

	void Bind() const override;
	void Unbind() const override;
};
