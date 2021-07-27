#include "TextureObject.h"
#include "RenderContext.h"
#include "IRenderDevice.h"

std::vector<std::string> TextureObject::ext{ ".jpg", ".png" };

std::shared_ptr<ITexture> TextureObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	BaseAssetObject<ITexture>::Transfer(read);
	
	assetPtr = RenderContext::Get().GetDevice().CreateTexture(filePath);
	return assetPtr;
}
