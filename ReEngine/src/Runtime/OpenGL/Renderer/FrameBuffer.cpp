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
	GLCall(glFramebufferTexture(GL_FRAMEBUFFER, GL_COLOR_ATTACHMENT0, texture.GetRenderId(), 0));
}
