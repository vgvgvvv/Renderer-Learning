#include "TextureObject.h"
#include "RenderContext.h"
#include "IRenderDevice.h"

std::vector<std::string> TextureObject::ext{ ".jpg", ".png" };

std::shared_ptr<ITexture> TextureObject::Load(bool onlyMetaInfo)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);
	if(!onlyMetaInfo)
	{
		assetPtr = RenderContext::Get().GetDevice().CreateTexture(filePath);
		return assetPtr;
	}
	return nullptr;
}
