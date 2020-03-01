#include "VertexArrayObject.h"

#include "Renderer.h"

VertexArrayObject::VertexArrayObject()
{
	GLCall(glGenVertexArrays(1, &render_id_))
}

VertexArrayObject::~VertexArrayObject()
{
	GLCall(glDeleteVertexArrays(1, &render_id_));
}

void VertexArrayObject::AddBuffer(const VertexBuffer& vb, const VertexBufferLayout& layout)
{
	Bind();
	vb.Bind();
	const auto& elements = layout.GetElements();
	uint32_t offset = 0;

	for(uint32_t i = 0; i < elements.size(); i ++)
	{
		const auto& ele = elements[i];
		GLCall(glEnableVertexAttribArray(i));
		GLCall(glVertexAttribPointer(i, ele.count, ele.type, ele.normalized, layout.GetStride(), (const void*)offset));
		offset += ele.count * VertexBufferElement::GetSizeOfType(ele.type);
	}
}

void VertexArrayObject::Bind() const
{
	GLCall(glBindVertexArray(render_id_));
}

void VertexArrayObject::Unbind() const
{
	GLCall(glBindVertexArray(0));
}
