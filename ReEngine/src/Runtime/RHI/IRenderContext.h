#pragma once
#include <cstdint>

#include "RHI_API.h"

class Color;
class IVertexArrayObject;
class IIndexBuffer;
class IShader;

class RHI_API IRenderContext
{
public:
	virtual void Clear(const Color& color) const = 0;
	virtual void Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, const IShader& shader) const = 0;
	virtual void SetAlpha(uint32_t from, uint32_t to) = 0;
};
