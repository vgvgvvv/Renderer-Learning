#pragma once
#include <cstdint>
#include <string>

#include "ITexture.h"
#include "ReOpenGL_API.h"

class ReOpenGL_API Texture : public ITexture
{
public:
	Texture(int32_t width, int32_t height, uint32_t slot = 0);
	Texture(const std::string& filepath, uint32_t slot = 0);
	~Texture();
	
	void Bind() const override;
	void Unbind() const override;

public:
	inline int32_t GetWidth() const { return width_; }
	inline int32_t GetHeight() const { return height_; }

private:
	uint32_t slot;
	
	std::string file_path_;
	uint8_t* local_buffer_;
	int32_t width_, height_, bpp_;
};
