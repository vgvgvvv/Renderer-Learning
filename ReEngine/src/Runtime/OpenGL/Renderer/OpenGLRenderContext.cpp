#include "OpenGLRenderContext.h"
#include <iostream>
#include "IndexBuffer.h"
#include "Shader.h"
#include "VertexArrayObject.h"
#include "Common.h"


void GLClearError()
{
	while (glGetError() != GL_NO_ERROR);
}

bool GLLogCall(const char* function, const char* file, int line)
{
	while (GLenum error = glGetError())
	{
		RE_LOG_ERROR("OpenGL", "[OpenGL Error] ({0}):{1} {2}:{3}", error, function, file, line);
		return false;
	}
	return true;
}

void OpenGLRenderContext::Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, const IShader& shader) const
{
	shader.Bind();
	vao.Bind();
	ib.Bind();

	GLCall(glDrawElements(GL_TRIANGLES, ib.GetCount(), GL_UNSIGNED_INT, nullptr));
}

void OpenGLRenderContext::Clear(const Color& color) const
{
	GLCall(glClearColor(color.r, color.g, color.b, color.a));
	GLCall(glClear(GL_COLOR_BUFFER_BIT));
}

void OpenGLRenderContext::SetAlpha(uint32_t from, uint32_t to)
{
	GLCall(glEnable(GL_ALPHA))
	GLCall(glBlendFunc(from, to));
}

