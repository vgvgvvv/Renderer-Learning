#include "DefaultAssetObject.h"

std::shared_ptr<UnknownAssetsFile> UnknownAssetsFile::Load(const std::string& filePath)
{
	return nullptr;
}

void DefaultAssetObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);

	assetPtr = UnknownAssetsFile::Load(filePath);
}
