#include "AssetLoader.h"



#include "CommonAssert.h"
#include "GameObject.h"
#include "ITexture.h"
#include "Mesh.h"
#include "Material.h"

static AssetLoader defaultLoader = AssetLoader(std::vector<std::string>());

AssetPtr AssetLoader::Load(const std::string& filePath)
{
	return AssetPtr();
}

void AssetLoader::Import(const std::string& filePath)
{
}

AssetLoader& AssetLoader::DefaultLoader()
{
	return defaultLoader;
}

#define IMPORT_LOADER_REGISTER(TypeName, exts) {TypeName::StaticClassName(), ImportAssetLoader<TypeName>(exts)},
#define NORMAL_LOADER_REGISTER(TypeName, exts) {TypeName::StaticClassName(), NormalAssetLoader<TypeName>(exts)},

AssetLoader& AssetLoaderFactory::GetLoader(const fs::directory_entry& entry)
{
	const auto ext = entry.path().extension().string();
	const auto filePath = entry.path().string();
	
	static std::unordered_map<std::string, AssetLoader> StaticLoaders{
		IMPORT_LOADER_REGISTER(MeshGroup, Assets::MeshGroupExt)
		IMPORT_LOADER_REGISTER(ITexture, Assets::TextureExt)
		
		NORMAL_LOADER_REGISTER(Material, Assets::MaterialExt)
		NORMAL_LOADER_REGISTER(GameObject, Assets::PrefabExt)
	};

	for (auto& loader : StaticLoaders)
	{
		if(loader.second.HasExt(ext))
		{
			return loader.second;
		}
	}

	RE_LOG_ERROR("Assets", "Cannot find loader for {0}", filePath.c_str());
	return defaultLoader;
}
