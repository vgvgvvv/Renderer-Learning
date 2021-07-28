#include "Image.h"
#include "stb_image.h"

std::shared_ptr<Image> Image::CreateDefault(const std::string& filePath)
{
	return std::make_shared<Image>();
}

std::shared_ptr<Image> Image::Load(const std::string& filePath)
{
	auto asset = std::make_shared<Image>();
	stbi_set_flip_vertically_on_load(1);
	asset->local_buffer_ = stbi_load(filePath.c_str(), 
		&asset->width_, 
		&asset->height_, 
		&asset->bpp_, 4);

	return asset;
}

Image::~Image()
{
	if (local_buffer_)
	{
		stbi_image_free(local_buffer_);
	}
}
