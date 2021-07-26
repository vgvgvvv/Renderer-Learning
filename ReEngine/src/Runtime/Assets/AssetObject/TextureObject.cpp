#include "TextureObject.h"

std::vector<std::string> TextureObject::ext{ ".jpg", ".png" };

void TextureObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);

	assetPtr = ITexture::Load(filePath);
}
