#pragma once
#include "BaseAssetObject.h"
#include "GameObject.h"
#include "re_reflect.hxx"
#include "GlobalAssets_API.h"

class GlobalAssets_API PrefabObject : public BaseAssetObject<GameObject>
{
public:

	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		transfer.transfer(&uuid, "uuid");
	}

	std::shared_ptr<GameObject> Load(bool onlyMetaInfo = false);
};
