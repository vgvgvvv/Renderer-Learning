#pragma once
#include "ClassInfo.h"
#include "AssetsClassDefine.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API Image
{
	DEFINE_CLASS(Image);
	DEFINE_IMPORT_ASSET_CLASS(Image);
public:
	~Image();

public:
	inline int32_t GetWidth() const { return width_; }
	inline int32_t GetHeight() const { return height_; }

private:
	uint8_t* local_buffer_;
	int32_t width_, height_, bpp_;
};

template <class TransferFunction>
void Image::TransferImportSetting(TransferFunction& transferFunc)
{
}
