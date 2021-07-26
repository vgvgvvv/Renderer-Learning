#pragma once
#include "BaseAssetObject.h"
#include "re_reflect.hxx"
#include "GlobalAssets_API.h"

class GlobalAssets_API UnknownAssetsFile
{
public:
	static std::shared_ptr<UnknownAssetsFile> Load(const std::string& filePath);
};

class GlobalAssets_API DefaultAssetObject : public BaseAssetObject<UnknownAssetsFile>
{
public:

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		BaseAssetObject<UnknownAssetsFile>::Transfer(transfer);
	}

};
