#pragma once
#include <cstdint>
#include <map>
#include <memory>
#include <string>



#include "IVertexBufferLayout.h"
#include "Matrix3x3.h"
#include "Matrix4x4.h"
#include "RHI_API.h"
#include "Vector2.h"
#include "Vector3.h"
#include "Vector4.h"

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
	virtual void InitGlobalUniform(IShader& shader) const = 0;
	virtual void Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, const IShader& shader) const = 0;
	virtual void DrawArray(const IVertexArrayObject& vao, const IShader& shader, int count) const = 0;
	virtual void SetAlpha(uint32_t from, uint32_t to) = 0;


	virtual std::shared_ptr<IFrameBuffer> CreateFrameBuffer() const = 0;
	virtual std::shared_ptr<ITexture> CreateTexture(uint32_t width, uint32_t height) const = 0;
	virtual std::shared_ptr<IIndexBuffer> CreateIndexBuffer(const uint32_t* data, uint32_t count) const = 0;
	virtual std::shared_ptr<IVertexBuffer> CreateVertexBuffer(const void* data, uint32_t size) const = 0;
	virtual std::shared_ptr<IVertexBufferLayout> CreateVertexBufferLayout() = 0;
	virtual std::shared_ptr<IVertexArrayObject> CreateVertexArrayObject() const = 0;
	virtual std::shared_ptr<IShader> CreateShader(const std::string& fileName) const = 0;
	virtual std::shared_ptr<IShader> CreateShader(const std::string& vertFileName, const std::string& fragFileName) const = 0;

public:

	std::map<std::string, float> GlobalUniform1F;
	std::map<std::string, std::tuple<float, float>> GlobalUniform2F;
	std::map<std::string, std::tuple<float, float, float>> GlobalUniform3F;
	std::map<std::string, std::tuple<float, float, float, float>> GlobalUniform4F;

	std::map<std::string, int> GlobalUniform1I;
	std::map<std::string, std::tuple<int, int>> GlobalUniform2I;
	std::map<std::string, std::tuple<int, int, int>> GlobalUniform3I;
	std::map<std::string, std::tuple<int, int, int, int>> GlobalUniform4I;

	std::map<std::string, Matrix3x3> GlobalMatrix3;
	std::map<std::string, Matrix4x4> GlobalMatrix4;
};
