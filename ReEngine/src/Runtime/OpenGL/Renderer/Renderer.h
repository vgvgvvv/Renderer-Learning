#pragma once

#include <cstdint>
#include <GL/glew.h>

#if _DEBUG
#define ASSERT(x) if(!(x)) __debugbreak();
#define GLCall(x) GLClearError();\
	x;\
	ASSERT(GLLogCall(#x, __FILE__, __LINE__))
#else
	#define ASSERT(x) x;
	#define GLCall(x) x;
#endif

void GLClearError();

bool GLLogCall(const char* function, const char* file, int line);


class Shader;
class IndexBuffer;
class VertexArrayObject;

class Renderer
{
public:

	void Clear() const;
	void Draw(const VertexArrayObject& vao, const IndexBuffer& ib, const Shader& shader) const;
	void SetAlpha(uint32_t from, uint32_t to);
};
