#pragma once
#include <cstdint>
#include <string>

class Texture
{
private:
	uint32_t render_id_;
	std::string file_path_;
	uint8_t* local_buffer_;
	int32_t width_, height_, bpp_;
public:
	Texture(const std::string& filepath);
	~Texture();
	
	void Bind(uint32_t slot = 0) const;
	void Unbind() const;

	inline int32_t GetWidth() const { return width_; }
	inline int32_t GetHeight() const { return height_; }
};
