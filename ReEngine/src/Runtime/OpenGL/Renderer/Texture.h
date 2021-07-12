#pragma once
#include <cstdint>
#include <string>
#include "ReOpenGL_API.h"

class ReOpenGL_API Texture
{
public:
	Texture(const std::string& filepath);
	~Texture();

	uint32_t GetRenderId() { return render_id_; }
	
	void Bind(uint32_t slot = 0) const;
	void Unbind() const;

	inline int32_t GetWidth() const { return width_; }
	inline int32_t GetHeight() const { return height_; }

private:
	uint32_t render_id_;
	std::string file_path_;
	uint8_t* local_buffer_;
	int32_t width_, height_, bpp_;
};
