#include "VertexArrayObject.h"

#include "OpenGLRenderContext.h"

VertexArrayObject::VertexArrayObject()
{
	GLCall(glGenVertexArrays(1, &render_id_))
}

VertexArrayObject::~VertexArrayObject()
{
	GLCall(glDeleteVertexArrays(1, &render_id_));
}

void VertexArrayObject::AddBuffer(const IVertexBuffer& vb, const IVertexBufferLayout& layout)
{
	Bind();
	vb.Bind();

	auto& realLayout = (VertexBufferLayout&)layout;
	
	const auto& elements = realLayout.GetElements();
	uint32_t offset = 0;

	for(uint32_t i = 0; i < elements.size(); i ++)
	{
		const auto& ele = elements[i];
		GLCall(glEnableVertexAttribArray(currentAttributeCount));
		GLCall(glVertexAttribPointer(currentAttributeCount, ele.count, ele.type, ele.normalized, realLayout.GetStride(), (const void*)offset));
		offset += ele.count * VertexBufferElement::GetSizeOfType(ele.type);
		currentAttributeCount++;
	}
}

void VertexArrayObject::RemoveAllBuffer()
{
	for(int i = 0; i < currentAttributeCount; i++)
	{
		GLCall(glDisableVertexAttribArray(i));
	}
	currentAttributeCount = 0;
}

void VertexArrayObject::Bind() const
{
	GLCall(glBindVertexArray(render_id_));
}

void VertexArrayObject::Unbind() const
{
	GLCall(glBindVertexArray(0));
}
