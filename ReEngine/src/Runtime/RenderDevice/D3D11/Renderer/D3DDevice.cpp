#include "D3DDevice.h"

DEFINE_DRIVEN_CLASS_IMP(D3DDevice, IRenderDevice)

void D3DDevice::Clear(const Color& color) const
{
}

void D3DDevice::InitGlobalUniform(IShader& shader) const
{
}

void D3DDevice::Draw(const IVertexArrayObject& vao, const IIndexBuffer& ib, IShader& shader) const
{
}

void D3DDevice::DrawArray(const IVertexArrayObject& vao, IShader& shader, int count) const
{
}

void D3DDevice::SetAlpha(uint32_t from, uint32_t to)
{
}

void D3DDevice::SetViewPort(float x, float y, float width, float height)
{
}

void D3DDevice::DrawLine(const Vector2& start, const Vector2& end)
{
}

void D3DDevice::DrawPolygon(const std::vector<Vector2>& min)
{
}

void D3DDevice::ClearFrameBuffer() const
{
}

std::shared_ptr<IFrameBuffer> D3DDevice::CreateFrameBuffer() const
{
	return nullptr;
}

std::shared_ptr<ITexture> D3DDevice::CreateTexture(const std::string& fileName) const
{
	return nullptr;
}

std::shared_ptr<ITexture> D3DDevice::CreateTexture(uint32_t width, uint32_t height) const
{
	return nullptr;
}

std::shared_ptr<IIndexBuffer> D3DDevice::CreateIndexBuffer(const uint32_t* data, uint32_t count) const
{
	return nullptr;
}

std::shared_ptr<IVertexBuffer> D3DDevice::CreateVertexBuffer(const void* data, uint32_t size) const
{
	return nullptr;
}

std::shared_ptr<IVertexBufferLayout> D3DDevice::CreateVertexBufferLayout()
{
	return nullptr;
}

std::shared_ptr<IVertexArrayObject> D3DDevice::CreateVertexArrayObject() const
{
	return nullptr;
}

std::shared_ptr<IShader> D3DDevice::CreateShader(const std::string& fileName) const
{
	return nullptr;
}

std::shared_ptr<IShader> D3DDevice::CreateShader(const std::string& vertFileName, const std::string& fragFileName) const
{
	return nullptr;
}
