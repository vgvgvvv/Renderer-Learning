#pragma once
#include <memory>


#include "AssetLoader/AssetLoader.h"
#include "uuid.h"
#include "re_reflect.hxx"
#include "Transfer/JsonTransfer.h"
#include "GlobalAssets_API.h"

template<class T>
class GlobalAssets_API BaseAssetObject
{
	
public:

	typedef T ObjType;

	friend AssetLoader<BaseAssetObject<T>>;

	BaseAssetObject()
	{
		uuid = uuids::uuid_system_generator{}();
	}
	
	T& Get() { return *assetPtr; }
	uuids::uuid& Uuid() { return uuid; }

	void Load(const std::string& filePath);
	
	bool IsLoaded() { return assetPtr != nullptr; }

	template<class TranslateFunction>
	void Transfer(TranslateFunction& transfer)
	{
		transfer.transfer(&uuid, "uuid");
	}
	
protected:
	std::shared_ptr<T> assetPtr;
	uuids::uuid uuid;
};

template <class T>
void GlobalAssets_API BaseAssetObject<T>::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);
	
}
