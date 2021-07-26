#pragma once
#include <string>
#include <vector>

#include "BaseAssetObject.h"
#include "ITexture.h"
#include "re_reflect.hxx"

class TextureLoader;

class CLASS() TextureObject : public BaseAssetObject<ITexture>
{
	META_OBJECT
public:
	friend TextureLoader;
	
	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		BaseAssetObject<ITexture>::Transfer(transfer);
	}
};
