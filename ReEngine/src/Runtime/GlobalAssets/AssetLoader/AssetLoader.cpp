#include "AssetLoader.h"



#include "CommonAssert.h"
#include "GameObject.h"
#include "Image.h"
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

void AssetLoader::Save(const std::string& filePath, std::shared_ptr<void> asset)
{
}

AssetLoader& AssetLoader::DefaultLoader()
{
	return defaultLoader;
}

#define IMPORT_LOADER_REGISTER(TypeName, exts) \
	{TypeName::StaticClassName(), std::make_shared<ImportAssetLoader<TypeName>>(exts)},
#define NORMAL_LOADER_REGISTER(TypeName, exts) \
	{TypeName::StaticClassName(), std::make_shared<NormalAssetLoader<TypeName>>(exts)},

static std::unordered_map<std::string, std::shared_ptr<AssetLoader>> StaticLoaders{
		IMPORT_LOADER_REGISTER(MeshGroup, Assets::MeshGroupExt)
		IMPORT_LOADER_REGISTER(Image, Assets::ImageExt)

		NORMAL_LOADER_REGISTER(Material, Assets::MaterialExt)
		NORMAL_LOADER_REGISTER(GameObject, Assets::PrefabExt)
};

#undef IMPORT_LOADER_REGISTER
#undef NORMAL_LOADER_REGISTER

AssetLoader& AssetLoaderFactory::GetLoader(const fs::directory_entry& entry)
{
	const auto ext = entry.path().extension().string();
	const auto filePath = entry.path().string();
	
	for (auto& loader : StaticLoaders)
	{
		if(loader.second->HasExt(ext))
		{
			return *loader.second;
		}
	}

	RE_LOG_ERROR("Assets", "Cannot find loader for {0}", filePath.c_str());
	return defaultLoader;
}

AssetLoader& AssetLoaderFactory::GetLoaderWithType(const std::string& className)
{
	return *StaticLoaders.at(className);
}

void AssetLoaderFactory::GetAllAssetsClassName(std::vector<std::string>* out)
{
	for (auto& pair : StaticLoaders)
	{
		out->push_back(pair.first);
	}
}
