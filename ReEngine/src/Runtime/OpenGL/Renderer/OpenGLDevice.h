#pragma once

#include <cstdint>

#include "Color.h"
#include "Common.h"
#include "GL/glew.h"
#include "IRenderDevice.h"
#include "ReOpenGL_API.h"


#if _DEBUG
#define GLCall(x) GLClearError();\
	x;\
	RE_ASSERT(GLLogCall(#x, __FILE__, __LINE__))
#else
	#define GLCall(x) x;
#endif

class IShader;
class IIndexBuffer;
class IVertexArrayObject;
void GLClearError();

bool GLLogCall(const char* function, const char* file, int line);


class Shader;
class IndexBuffer;
class VertexArrayObject;


class ReOpenGL_API OpenGLDevice : public IRenderDevice
{
public:

	void Clear(const Color& color) const override;
	void InitGlobalUniform(IShader& shader) const override;
	void Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, const IShader& shader) const override;
	void DrawArray(const IVertexArrayObject& vao, const IShader& shader, int count) const override;
	void SetAlpha(uint32_t from, uint32_t to) override;
	void SetViewPort(float x, float y, float width, float height) override;
	void DrawLine(const Vector2& start, const Vector2& end) override;
	void DrawPolygon(const std::vector<Vector2>& points) override;

	void ClearFrameBuffer() const override;
public:
	std::shared_ptr<IFrameBuffer> CreateFrameBuffer() const override;
	std::shared_ptr<ITexture> CreateTexture(uint32_t width, uint32_t height) const override;
	std::shared_ptr<IIndexBuffer> CreateIndexBuffer(const uint32_t* data, uint32_t count) const override;
	std::shared_ptr<IVertexBuffer> CreateVertexBuffer(const void* data, uint32_t size) const override;
	std::shared_ptr<IVertexBufferLayout> CreateVertexBufferLayout() override;
	std::shared_ptr<IVertexArrayObject> CreateVertexArrayObject() const override;
	std::shared_ptr<IShader> CreateShader(const std::string& fileName) const override;
	std::shared_ptr<IShader> CreateShader(const std::string& vertFileName, const std::string& fragFileName) const override;
};
