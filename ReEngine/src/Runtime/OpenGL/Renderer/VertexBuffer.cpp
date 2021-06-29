﻿#include "VertexBuffer.h"
#include "OpenGLRenderContext.h"

VertexBuffer::VertexBuffer(const void* data, uint32_t size) : render_id_(0)
{
	GLCall(glGenBuffers(1, &render_id_));
	GLCall(glBindBuffer(GL_ARRAY_BUFFER, render_id_));
	GLCall(glBufferData(GL_ARRAY_BUFFER, size, data, GL_STATIC_DRAW));
}

VertexBuffer::~VertexBuffer()
{
	glDeleteBuffers(1, &render_id_);
}

void VertexBuffer::Bind() const
{
	GLCall(glBindBuffer(GL_ARRAY_BUFFER, render_id_));
}

void VertexBuffer::Unbind() const
{
	GLCall(glBindBuffer(GL_ARRAY_BUFFER, 0));
}