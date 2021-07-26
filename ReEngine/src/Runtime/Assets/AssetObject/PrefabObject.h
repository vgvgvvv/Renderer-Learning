#pragma once
#include "BaseAssetObject.h"
#include "GameObject.h"
#include "re_reflect.hxx"

class CLASS() PrefabObject : public BaseAssetObject<GameObject>
{
	META_OBJECT
public:

	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		BaseAssetObject<GameObject>::Transfer(transfer);
	}

	void Load(const std::string& filePath);

};
