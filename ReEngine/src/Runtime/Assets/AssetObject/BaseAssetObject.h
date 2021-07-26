#pragma once
#include <memory>


#include "AssetLoader/AssetLoader.h"
#include "uuid.h"
#include "re_reflect.hxx"
#include "Transfer/JsonTransfer.h"

template<class T>
class CLASS() BaseAssetObject
{
	META_OBJECT
public:

	friend AssetLoader<BaseAssetObject<T>>;

	BaseAssetObject()
	{
		uuid = uuids::uuid_system_generator{}();
	}
	
	T& Get() { return *assetPtr; }
	uuids::uuid& Uuid() { return uuid; }

	template<class TranslateFunction>
	void Transfer(TranslateFunction& transfer)
	{
		transfer.transfer(uuid, "uuid");
	}
	
protected:
	std::shared_ptr<T> assetPtr;
	uuids::uuid uuid;
};
