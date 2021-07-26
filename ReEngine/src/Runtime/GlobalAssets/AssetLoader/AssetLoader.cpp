#include "AssetLoader.h"



#include "AssetObject/DefaultAssetObject.h"
#include "AssetObject/MeshObject.h"
#include "AssetObject/PrefabObject.h"
#include "AssetObject/TextureObject.h"

template<class T>
bool FindExt(const std::string& ext)
{
	return std::find(T::ext.begin(), T::ext.end(), ext) != T::ext.end();
}

std::shared_ptr<BaseAssetLoader> AssetLoaderFactory::CreateLoader(const fs::directory_entry& entry)
{
	const auto ext = entry.path().extension().string();
	const auto filePath = entry.path().string();

	if(FindExt<TextureObject>(ext))
	{
		return Create<TextureObject>(entry);
	}
	else if(FindExt<MeshObject>(ext))
	{
		return Create<MeshObject>(entry);
	}
	else if(FindExt<PrefabObject>(ext))
	{
		return Create<PrefabObject>(entry);
	}
	return Create<DefaultAssetObject>(entry);
}

