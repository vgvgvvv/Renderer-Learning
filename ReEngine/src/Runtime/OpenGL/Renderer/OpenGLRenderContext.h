﻿#pragma once

#include <cstdint>

#include "Color.h"
#include "Common.h"
#include "GL/glew.h"
#include "IRenderContext.h"
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


class ReOpenGL_API OpenGLRenderContext : public IRenderContext
{
public:

	void Clear(const Color& color) const override;
	void Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, const IShader& shader) const override;
	void SetAlpha(uint32_t from, uint32_t to) override;
};
