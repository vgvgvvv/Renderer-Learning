#pragma once
#include <cstdint>
#include <memory>
#include <string>

#include "RHI_API.h"

class IVertexBuffer;
class ITexture;
class IFrameBuffer;
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

	virtual std::shared_ptr<IFrameBuffer> CreateFrameBuffer() = 0;
	virtual std::shared_ptr<ITexture> CreateTexture(uint32_t width, uint32_t height) = 0;
	virtual std::shared_ptr<IIndexBuffer> CreateIndexBuffer(const uint32_t* data, uint32_t count) = 0;
	virtual std::shared_ptr<IVertexBuffer> CreateVertexBuffer(const void* data, uint32_t size) = 0;
	virtual std::shared_ptr<IVertexArrayObject> CreateVertexArrayObject() = 0;
	virtual std::shared_ptr<IShader> CreateShader(const std::string& fileName) = 0;
};
