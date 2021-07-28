#pragma once
#include <string>
#include "Singleton.h"
#include "GlobalAssets_API.h"
#include <filesystem>
#include <map>

#include "AssetLoader/AssetLoader.h"
#include "inifile.h"
#include "Common.h"

#include "uuid.h"


namespace fs = std::filesystem;

class GlobalAssets_API ResourcesManager
{
	DEFINE_SINGLETON(ResourcesManager);
public:

	AssetPtr Load(const std::string& fileName);

	template<class T>
	void SaveToFile(const std::string& filePath, std::shared_ptr<void> asset);

	void CheckImport(const std::string& root);

private:
	bool CheckIfAssetNeedImport(const fs::directory_entry& entry);
	void ImportAsset(const fs::directory_entry& entry);

private:
	std::map<uuids::uuid, AssetPtr> resourcesMap;
};

template <class T>
void ResourcesManager::SaveToFile(const std::string& filePath, std::shared_ptr<void> asset)
{
	AssetLoader& assetLoader = AssetLoaderFactory::GetLoaderWithType(T::StaticClassName());
	assetLoader.Save(filePath, asset);
}


