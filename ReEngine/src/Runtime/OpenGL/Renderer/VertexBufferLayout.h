#pragma once
#include <cassert>
#include <vector>
#include "Common.h"
#include "IVertexBufferLayout.h"
#include "OpenGLRenderContext.h"
#include "ReOpenGL_API.h"


struct VertexBufferElement
{
	uint32_t type;
	uint32_t count;
	uint8_t normalized;

	static uint32_t GetSizeOfType(uint32_t type)
	{
		switch (type)
		{
		case GL_FLOAT: return sizeof(float);
		case GL_INT: return sizeof(int32);
		case GL_UNSIGNED_INT: return sizeof(uint32);
		case GL_BYTE: return sizeof(int8);
		case GL_UNSIGNED_BYTE: return sizeof(uint8);
		}
		RE_ASSERT_MSG(false, "type is unkonwn");
		return 0;
	}
};

class ReOpenGL_API VertexBufferLayout : public IVertexBufferLayout
{
private:
	std::vector<VertexBufferElement> elements_;
	uint32_t stride_;
public:
	VertexBufferLayout()
		: stride_(0) {}

	template<typename T>
	void Push(uint32_t count)
	{
		RE_ASSERT_MSG(false, "push type is unkonwn");
	}

	template<>
	void Push<float>(uint32_t count)
	{
		elements_.push_back({GL_FLOAT, count, GL_FALSE});
		stride_ += VertexBufferElement::GetSizeOfType(GL_FLOAT) * count;
	}

	template<>
	void Push<uint32_t>(uint32_t count)
	{
		elements_.push_back({ GL_UNSIGNED_INT, count, GL_FALSE });
		stride_ += VertexBufferElement::GetSizeOfType(GL_UNSIGNED_INT) * count;
	}

	template<>
	void Push<uint8_t>(uint32_t count)
	{
		elements_.push_back({ GL_UNSIGNED_BYTE, count, GL_TRUE });
		stride_ += VertexBufferElement::GetSizeOfType(GL_UNSIGNED_BYTE) * count;
	}

	// todo more types..


	void PushVector3() override;
	void PushUV() override;
	void PushColor() override;
	
	std::vector<VertexBufferElement> GetElements() const { return elements_; }
	uint32_t GetStride() const { return stride_; }
};
