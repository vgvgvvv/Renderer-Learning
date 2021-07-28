#include "AssetLoader.h"



#include "AssetObject/DefaultAssetObject.h"
#include "AssetObject/MeshObject.h"
#include "AssetObject/TextureObject.h"
#include "Material.h"
#include "CommonExt.h"
#include "GameObject.h"


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
	else if(ext == Assets::PrefabExt)
	{
		return Create<DefaultAssetObject<GameObject>>(entry);
	}
	else if(ext == Assets::MaterialExt)
	{
		return Create<DefaultAssetObject<Material>>(entry);
	}
	return nullptr;
}

