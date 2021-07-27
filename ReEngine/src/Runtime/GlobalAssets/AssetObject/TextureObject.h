#pragma once
#include <string>
#include <vector>

#include "BaseAssetObject.h"
#include "ITexture.h"
#include "re_reflect.hxx"
#include "GlobalAssets_API.h"

class TextureLoader;

class GlobalAssets_API TextureObject : public BaseAssetObject<ITexture>
{
public:
	friend TextureLoader;
	
	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		transfer.transfer(&uuid, "uuid");
	}

	std::shared_ptr<ITexture> Load(bool onlyMetaInfo = false);
};
