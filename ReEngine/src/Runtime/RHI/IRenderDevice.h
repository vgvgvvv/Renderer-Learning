#pragma once
#include <cstdint>
#include <map>
#include <memory>
#include <string>
#include <vector>


#include "IVertexBufferLayout.h"
#include "Matrix3x3.h"
#include "Matrix4x4.h"
#include "ClassInfo.h"
#include "RHI_API.h"

class IVertexBuffer;
class ITexture;
class IFrameBuffer;
class Color;
class IVertexArrayObject;
class IIndexBuffer;
class IShader;

enum class FaceCullType
{
	Front,
	Back,
	FrontAndBack
};

class RHI_API IRenderDevice
{
	DEFINE_CLASS(IRenderDevice)
public:
	virtual void Clear(const Color& color) const = 0;
	virtual void InitGlobalUniform(IShader& shader) const = 0;
	virtual void Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, IShader& shader) const = 0;
	virtual void DrawArray(const IVertexArrayObject& vao, IShader& shader, int count) const = 0;
	virtual void SetAlpha(uint32_t from, uint32_t to) = 0;
	virtual void SetFaceCull(FaceCullType cullType) = 0;
	virtual void SetViewPort(float x, float y, float width, float height) = 0;
	virtual void DrawLine(const Vector2& start, const Vector2& end) = 0;
	virtual void DrawPolygon(const std::vector<Vector2>& min) = 0;

	virtual void ClearFrameBuffer() const = 0;
public:
	virtual std::shared_ptr<IFrameBuffer> CreateFrameBuffer() const = 0;
	virtual std::shared_ptr<ITexture> CreateTexture(const std::string& fileName) const = 0;
	virtual std::shared_ptr<ITexture> CreateTexture(uint32_t width, uint32_t height) const = 0;
	virtual std::shared_ptr<IIndexBuffer> CreateIndexBuffer(const uint32_t* data, uint32_t count) const = 0;
	virtual std::shared_ptr<IVertexBuffer> CreateVertexBuffer(const void* data, uint32_t size) const = 0;
	virtual std::shared_ptr<IVertexBufferLayout> CreateVertexBufferLayout() = 0;
	virtual std::shared_ptr<IVertexArrayObject> CreateVertexArrayObject() const = 0;
	virtual std::shared_ptr<IShader> CreateShader(const std::string& fileName) const = 0;
	virtual std::shared_ptr<IShader> CreateShader(const std::string& vertFileName, const std::string& fragFileName) const = 0;

protected:

	std::map<std::string, float> GlobalUniform1F;
	std::map<std::string, std::tuple<float, float>> GlobalUniform2F;
	std::map<std::string, std::tuple<float, float, float>> GlobalUniform3F;
	std::map<std::string, std::tuple<float, float, float, float>> GlobalUniform4F;

	std::map<std::string, int> GlobalUniform1I;
	std::map<std::string, std::tuple<int, int>> GlobalUniform2I;
	std::map<std::string, std::tuple<int, int, int>> GlobalUniform3I;
	std::map<std::string, std::tuple<int, int, int, int>> GlobalUniform4I;

	std::map<std::string, std::vector<float>> GlobalMatrix3;
	std::map<std::string, std::vector<float>> GlobalMatrix4;

public:

	void AddGlobalUniform1F(const std::string& name, float v1);
	void AddGlobalUniform2F(const std::string& name, float v1, float v2);
	void AddGlobalUniform3F(const std::string& name, float v1, float v2, float v3);
	void AddGlobalUniform4F(const std::string& name, float v1, float v2, float v3, float v4);

	void AddGlobalUniform1I(const std::string& name, int v1);
	void AddGlobalUniform2I(const std::string& name, int v1, int v2);
	void AddGlobalUniform3I(const std::string& name, int v1, int v2, int v3);
	void AddGlobalUniform4I(const std::string& name, int v1, int v2, int v3, int v4);

	void AddGlobalUniformMatrix3(const std::string& name, const Matrix3x3& v);
	void AddGlobalUniformMatrix4(const std::string& name, const Matrix4x4& v);
};
