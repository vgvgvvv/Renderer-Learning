#pragma once
#include "BaseAssetObject.h"
#include "re_reflect.hxx"

class UnknownAssetsFile
{
public:
	
};

class CLASS() DefaultAssetObject : public BaseAssetObject<UnknownAssetsFile>
{
	META_OBJECT
public:

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		BaseAssetObject<UnknownAssetsFile>::Transfer(transfer);
	}

};
