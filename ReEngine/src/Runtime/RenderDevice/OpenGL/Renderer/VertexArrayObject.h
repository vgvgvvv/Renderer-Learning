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
	
	void AddBuffer(const IVertexBuffer& vb, const IVertexBufferLayout& layout) override;
	void RemoveAllBuffer() override;

	void Bind() const override;
	void Unbind() const override;

private:
	int32 currentAttributeCount = 0;
};
