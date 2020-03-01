﻿#include "Renderer.h"
#include <iostream>


#include "IndexBuffer.h"
#include "Shader.h"
#include "VertexArrayObject.h"


void GLClearError()
{
	while (glGetError() != GL_NO_ERROR);
}

bool GLLogCall(const char* function, const char* file, int line)
{
	while (GLenum error = glGetError())
	{
		std::cout << "[OpenGL Error] (" << error << "):" <<
			function << " " << file << ":" << line << std::endl;
		return false;
	}
	return true;
}

void Renderer::Draw(const VertexArrayObject& vao, const IndexBuffer& ib, const Shader& shader) const
{
	shader.Bind();
	vao.Bind();
	ib.Bind();

	GLCall(glDrawElements(GL_TRIANGLES, ib.GetCount(), GL_UNSIGNED_INT, nullptr));
}

void Renderer::Clear() const
{
	GLCall(glClear(GL_COLOR_BUFFER_BIT));
}

void Renderer::SetAlpha(uint32_t from, uint32_t to)
{
	GLCall(glEnable(GL_ALPHA))
	GLCall(glBlendFunc(from, to));
}

