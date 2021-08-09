#pragma once
#include "IRenderDevice.h"
#include "ClassInfo.h"

class D3DDevice : public IRenderDevice
{
	DEFINE_DRIVEN_CLASS(D3DDevice, IRenderDevice)
public:

	void Clear(const Color& color) const override;
	void InitGlobalUniform(IShader& shader) const override;
	void Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, IShader& shader) const override;
	void DrawArray(const IVertexArrayObject& vao, IShader& shader, int count) const override;
	void SetAlpha(uint32_t from, uint32_t to) override;
	void SetViewPort(float x, float y, float width, float height) override;
	void DrawLine(const Vector2& start, const Vector2& end) override;
	void DrawPolygon(const std::vector<Vector2>& min) override;
	void ClearFrameBuffer() const override;
	std::shared_ptr<IFrameBuffer> CreateFrameBuffer() const override;
	std::shared_ptr<ITexture> CreateTexture(const std::string& fileName) const override;
	std::shared_ptr<ITexture> CreateTexture(uint32_t width, uint32_t height) const override;
	std::shared_ptr<IIndexBuffer> CreateIndexBuffer(const uint32_t* data, uint32_t count) const override;
	std::shared_ptr<IVertexBuffer> CreateVertexBuffer(const void* data, uint32_t size) const override;
	std::shared_ptr<IVertexBufferLayout> CreateVertexBufferLayout() override;
	std::shared_ptr<IVertexArrayObject> CreateVertexArrayObject() const override;
	std::shared_ptr<IShader> CreateShader(const std::string& fileName) const override;
	std::shared_ptr<IShader> CreateShader(const std::string& vertFileName, const std::string& fragFileName) const
	override;
};
