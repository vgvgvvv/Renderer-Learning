#include "FrameBuffer.h"

#include "ITexture.h"
#include "OpenGLDevice.h"

FrameBuffer::FrameBuffer()
{
	GLCall(glGenFramebuffers(1, &render_id_));
}

FrameBuffer::~FrameBuffer()
{
	GLCall(glDeleteFramebuffers(1, &render_id_));
}

void FrameBuffer::Bind() const
{
	GLCall(glBindFramebuffer(GL_FRAMEBUFFER, render_id_));
}

void FrameBuffer::Unbind() const
{
	GLCall(glBindFramebuffer(GL_FRAMEBUFFER, 0));
}

void FrameBuffer::SetFrameBufferTexture(const ITexture& texture)
{
	Bind();
	GLCall(glFramebufferTexture(GL_FRAMEBUFFER, GL_COLOR_ATTACHMENT0, texture.GetRenderId(), 0));
	GLenum DrawBuffers[1] = { GL_COLOR_ATTACHMENT0 };
	GLCall(glDrawBuffers(1, DrawBuffers));
	RE_ASSERT(glCheckFramebufferStatus(GL_FRAMEBUFFER) == GL_FRAMEBUFFER_COMPLETE)
	Unbind();
}
