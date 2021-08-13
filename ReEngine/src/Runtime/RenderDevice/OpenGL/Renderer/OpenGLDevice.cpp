#include "OpenGLDevice.h"
#include <iostream>
#include "IndexBuffer.h"
#include "Shader.h"
#include "VertexArrayObject.h"
#include "Common.h"
#include "FrameBuffer.h"
#include "Texture.h"
#include "Vector2.h"


DEFINE_DRIVEN_CLASS_IMP(OpenGLDevice, IRenderDevice)

void GLClearError()
{
	GLenum error = glGetError();
	while (error != GL_NO_ERROR);
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

void OpenGLDevice::Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, IShader& shader) const
{
	shader.Bind();
	vao.Bind();
	ib.Bind();

	InitGlobalUniform(shader);

	GLCall(glDrawElements(GL_TRIANGLES, ib.GetCount(), GL_UNSIGNED_INT, nullptr));
}

void OpenGLDevice::DrawArray(const IVertexArrayObject& vao, IShader& shader, int count) const
{
	vao.Bind();
	shader.Bind();

	InitGlobalUniform(shader);
	
	GLCall(glDrawArrays(GL_TRIANGLES, 0, count));
}

void OpenGLDevice::Clear(const Color& color) const
{
	GLCall(glClearColor(color.r, color.g, color.b, color.a));
	GLCall(glClear(GL_COLOR_BUFFER_BIT));
}

void OpenGLDevice::SetAlpha(uint32_t from, uint32_t to)
{
	GLCall(glEnable(GL_ALPHA))
	GLCall(glBlendFunc(from, to));
}


void OpenGLDevice::SetDepthTest(bool enable)
{
	GLCall(glEnable(GL_DEPTH_TEST))
	GLCall(glDepthMask(enable ? GL_TRUE : GL_FALSE))
}


void OpenGLDevice::SetDepthFunction(DepthFunctionType type)
{
	GLCall(glEnable(GL_DEPTH_TEST))
	switch (type)
	{
	case DepthFunctionType::Always: 
		GLCall(glDepthFunc(GL_ALWAYS))
		break;
	case DepthFunctionType::Never:
		GLCall(glDepthFunc(GL_NEVER))
		break;
	case DepthFunctionType::Less:
		GLCall(glDepthFunc(GL_LESS))
		break;
	case DepthFunctionType::Equal:
		GLCall(glDepthFunc(GL_EQUAL))
		break;
	case DepthFunctionType::LEqual:
		GLCall(glDepthFunc(GL_LEQUAL))
		break;
	case DepthFunctionType::Greater:
		GLCall(glDepthFunc(GL_GREATER))
		break;
	case DepthFunctionType::NotEqual:
		GLCall(glDepthFunc(GL_NOTEQUAL))
		break;
	case DepthFunctionType::GEqual:
		GLCall(glDepthFunc(GL_GEQUAL))
		break;
	default: ;
	}
}

void OpenGLDevice::SetFaceCull(FaceCullType cullType)
{
	GLCall(glEnable(GL_CULL_FACE));
	switch (cullType)
	{
	case FaceCullType::Back:
		GLCall(glCullFace(GL_BACK));
		break;
	case FaceCullType::Front:
		GLCall(glCullFace(GL_FRONT));
		break;
	case FaceCullType::FrontAndBack:
		GLCall(glCullFace(GL_FRONT_AND_BACK));
		break;
	}
}

void OpenGLDevice::SetViewPort(float x, float y, float width, float height)
{
	GLCall(glViewport(x, y, width, height));
}

void OpenGLDevice::DrawLine(const Vector2& start, const Vector2& end)
{
	GLCall(glBegin(GL_LINES));
	GLCall(glVertex2f(start.x, start.y));
	GLCall(glVertex2f(end.x, end.y));
	GLCall(glEnd());
}

void OpenGLDevice::DrawPolygon(const std::vector<Vector2>& points)
{
	GLCall(glBegin(GL_POLYGON));
	for (auto& point : points) {
		GLCall(glVertex2f(point.x, point.y));
	}
	GLCall(glEnd());
}

void OpenGLDevice::ClearFrameBuffer() const
{
	GLCall(GLCall(glBindFramebuffer(GL_FRAMEBUFFER, 0)));
}

std::shared_ptr<IFrameBuffer> OpenGLDevice::CreateFrameBuffer() const
{
	return std::make_shared<FrameBuffer>();
}

std::shared_ptr<ITexture> OpenGLDevice::CreateTexture(const std::string& fileName) const
{
	return std::make_shared<Texture>(fileName);
}

std::shared_ptr<ITexture> OpenGLDevice::CreateTexture(uint32_t width, uint32_t height) const
{
	return std::make_shared<Texture>(width, height);
}

std::shared_ptr<IIndexBuffer> OpenGLDevice::CreateIndexBuffer(const uint32_t* data, uint32_t count) const
{
	return std::make_shared<IndexBuffer>(data, count);
}

std::shared_ptr<IVertexBuffer> OpenGLDevice::CreateVertexBuffer(const void* data, uint32_t size) const
{
	return std::make_shared<VertexBuffer>(data, size);
}

std::shared_ptr<IVertexBufferLayout> OpenGLDevice::CreateVertexBufferLayout()
{
	return std::make_shared<VertexBufferLayout>();
}

std::shared_ptr<IVertexArrayObject> OpenGLDevice::CreateVertexArrayObject() const
{
	return std::make_shared<VertexArrayObject>();
}

std::shared_ptr<IShader> OpenGLDevice::CreateShader(const std::string& fileName) const
{
	return std::make_shared<Shader>(fileName);
}

std::shared_ptr<IShader> OpenGLDevice::CreateShader(const std::string& vertFileName,
	const std::string& fragFileName) const
{
	return std::make_shared<Shader>(
		Path::Combine(Path::GetShaderSourcePath(), vertFileName), 
		Path::Combine(Path::GetShaderSourcePath(), fragFileName));
}


void OpenGLDevice::InitGlobalUniform(IShader& shader) const
{
	//
	for (std::pair<std::string, float> pair : GlobalUniform1F)
	{
		shader.SetUniform1f(pair.first, pair.second);
	}
	for (std::pair<std::string, std::tuple<float, float>> pair : GlobalUniform2F)
	{
		shader.SetUniform2f(pair.first, 
			std::get<0>(pair.second), 
			std::get<1>(pair.second));
	}
	for (std::pair<std::string, std::tuple<float, float, float>> pair : GlobalUniform3F)
	{
		shader.SetUniform3f(pair.first, 
			std::get<0>(pair.second), 
			std::get<1>(pair.second), 
			std::get<2>(pair.second));
	}
	for (std::pair<std::string, std::tuple<float, float, float, float>> pair : GlobalUniform4F)
	{
		shader.SetUniform4f(pair.first,
			std::get<0>(pair.second),
			std::get<1>(pair.second),
			std::get<2>(pair.second),
			std::get<3>(pair.second));
	}

	//
	for (std::pair<std::string, int> pair : GlobalUniform1I)
	{
		shader.SetUniform1i(pair.first, pair.second);
	}
	for (std::pair<std::string, std::tuple<int, int>> pair : GlobalUniform2I)
	{
		shader.SetUniform2i(pair.first,
			std::get<0>(pair.second),
			std::get<1>(pair.second));
	}
	for (std::pair<std::string, std::tuple<int, int, int>> pair : GlobalUniform3I)
	{
		shader.SetUniform3i(pair.first,
			std::get<0>(pair.second),
			std::get<1>(pair.second),
			std::get<2>(pair.second));
	}
	for (std::pair<std::string, std::tuple<int, int, int, int>> pair : GlobalUniform4I)
	{
		shader.SetUniform4i(pair.first,
			std::get<0>(pair.second),
			std::get<1>(pair.second),
			std::get<2>(pair.second),
			std::get<3>(pair.second));
	}

	//
	for (std::pair<std::string, std::vector<float>> pair : GlobalMatrix3)
	{
		shader.SetUniformMatrix3(pair.first, pair.second);
	}

	//
	for (std::pair<std::string, std::vector<float>> pair : GlobalMatrix4)
	{
		shader.SetUniformMatrix4(pair.first, pair.second);
	}
}
