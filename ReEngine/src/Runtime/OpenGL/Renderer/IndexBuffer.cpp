#include "IndexBuffer.h"

#include "OpenGLRenderContext.h"

IndexBuffer::IndexBuffer(const uint32_t* data, uint32_t count)
	: count_(count)
{
	GLCall(glGenBuffers(1, &render_id_));
	GLCall(glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, render_id_));
	GLCall(glBufferData(GL_ELEMENT_ARRAY_BUFFER, count * sizeof(uint32_t), data, GL_STATIC_DRAW))
}

IndexBuffer::~IndexBuffer()
{
	GLCall(glDeleteBuffers(1, &render_id_));
}

void IndexBuffer::Bind() const
{
	GLCall(glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, render_id_));
}

void IndexBuffer::Unbind() const
{
	GLCall(glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, 0));
}
