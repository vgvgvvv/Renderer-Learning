#pragma once
#include "BaseAssetObject.h"
#include "GlobalAssets_API.h"

class GlobalAssets_API UnknownAssetsFile
{
};

class GlobalAssets_API DefaultAssetObject : public BaseAssetObject<UnknownAssetsFile>
{
public:

	
	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		transfer.transfer(&uuid, "uuid");
	}

	std::shared_ptr<UnknownAssetsFile> Load(bool onlyMetaInfo = false);
};
