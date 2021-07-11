#include "FrameBuffer.h"
#include "OpenGL.h"
#include "OpenGLRenderContext.h"

FrameBuffer::FrameBuffer()
{
	GLCall(glGenFramebuffers(1, &render_id_));
}

FrameBuffer::~FrameBuffer()
{
	GLCall(glDeleteFramebuffers(1, &render_id_));
}

void FrameBuffer::Bind()
{
	GLCall(glBindFramebuffer(GL_FRAMEBUFFER, render_id_));
}

void FrameBuffer::Unbind()
{
	GLCall(glBindFramebuffer(GL_FRAMEBUFFER, 0));
}
