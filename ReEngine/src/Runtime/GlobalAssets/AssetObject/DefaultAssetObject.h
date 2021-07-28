#pragma once
#include "BaseAssetObject.h"
#include "GlobalAssets_API.h"


template<class TAsset>
class GlobalAssets_API DefaultAssetObject : public BaseAssetObject<TAsset>
{
public:

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		transfer.transfer(&this->uuid, "uuid");
	}

	std::shared_ptr<TAsset> Load(bool onlyMetaInfo = false)
	{
		std::string metaFilePath(filePath + ".meta");
		JsonRead readMeta(metaFilePath);

		this->Transfer(readMeta);

		if(!onlyMetaInfo)
		{
			std::shared_ptr<TAsset> asset = std::make_shared<TAsset>();

			JsonRead readAsset(this->filePath);
			asset->Transfer(readAsset);
		}
		return nullptr;
	}
};
