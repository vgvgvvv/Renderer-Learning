#include "Texture.h"

#include "OpenGLRenderContext.h"
#include "stb_image.h"
#include "VertexArrayObject.h"


Texture::Texture(int32_t width, int32_t height, uint32_t slot)
	: slot(slot)
	, local_buffer_(nullptr)
	, width_(width)
	, height_(height)
	, bpp_(0)
{
	GLCall(glGenTextures(1, &render_id_));
	GLCall(glBindTexture(GL_TEXTURE_2D, render_id_));

	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR));
	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR));
	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE));
	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE));

	GLCall(glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA8, width_, height_, 0, GL_RGBA, GL_UNSIGNED_BYTE, local_buffer_));
	GLCall(glBindTexture(GL_TEXTURE_2D, 0));
}

Texture::Texture(const std::string& filepath, uint32_t slot)
	: slot(slot)
	, file_path_(filepath)
	, local_buffer_(nullptr)
	, width_(0)
	, height_(0)
	, bpp_(0)
{
	stbi_set_flip_vertically_on_load(1);

	local_buffer_ = stbi_load(filepath.c_str(), &width_, &height_, &bpp_, 4);
	
	GLCall(glGenTextures(1, &render_id_));
	GLCall(glBindTexture(GL_TEXTURE_2D, render_id_));

	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR));
	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR));
	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE));
	GLCall(glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE));

	GLCall(glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA8, width_, height_, 0, GL_RGBA, GL_UNSIGNED_BYTE, local_buffer_));
	GLCall(glBindTexture(GL_TEXTURE_2D, 0));

	if(local_buffer_)
	{
		stbi_image_free(local_buffer_);
	}
}

Texture::~Texture()
{
	GLCall(glDeleteTextures(1, &render_id_));
}

void Texture::Bind() const
{
	//绑定贴图的位置，以供shader使用
	GLCall(glActiveTexture(GL_TEXTURE0 + slot));
	GLCall(glBindTexture(GL_TEXTURE_2D, render_id_));
}

void Texture::Unbind() const
{
	GLCall(glBindTexture(GL_TEXTURE_2D, 0));
}
