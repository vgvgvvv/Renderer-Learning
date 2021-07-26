#include "TextureObject.h"

std::vector<std::string> TextureObject::ext{ ".jpg", ".png" };

std::shared_ptr<ITexture> TextureObject::Load(const std::string& filePath)
{
	BaseAssetObject<ITexture>::Load(filePath);
	// TODO
}
