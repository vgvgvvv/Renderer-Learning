#include "ResourceManager.h"
#include "AssetLoader/AssetLoader.h"
#include "Config/Config.h"
#include "Logging/Log.h"
#include "Misc/Path.h"

template <class T>
T& ResourcesManager::Load(const std::string& fileName)
{
	auto fullPath = Path::Combine(Path::GetResourcesPath(), fileName);

	auto assetLoader = AssetLoaderFactory::Create(fullPath);

	if(!assetLoader)
	{
		RE_LOG_ERROR("Assets", "Cannot find suitable Loader by file {0}", fileName.c_str());
		return std::make_shared<T>();
	}
	
	assetLoader->Load();
	std::shared_ptr<T> assetObj = assetLoader->Get();

	if(assetObj)
	{
		// 注册资源到全局资源表
		resourcesMap.insert(std::pair<uuids::uuid, std::shared_ptr<T>>(assetObj->Uuid(), assetObj));
	}

	return *assetObj;
}

void ResourcesManager::CheckImport(const std::string& root)
{
	std::string targetPath = root;

	if(!fs::exists(root))
	{
		RE_LOG_WARN("Resources", "Cannot find directory : {0}", root.c_str());
		return;
	}

	for (const auto& entry : fs::directory_iterator(targetPath))
	{
		if(entry.path().extension() == ".meta")
		{
			continue;
		}
		if(entry.is_directory())
		{
			CheckImport(entry.path().string());
		}
		else
		{
			if(CheckIfAssetNeedImport(entry))
			{
				RE_LOG_INFO("Resources", "Import Asset : {0}", entry.path().string().c_str());
				ImportAsset(entry);
			}
		}
	}
	
}

bool ResourcesManager::CheckIfAssetNeedImport(const fs::directory_entry& entry)
{
	auto metaFileEntry = fs::directory_entry(entry.path().string() + ".meta");
	
	if(!fs::exists(metaFileEntry))
	{
		return true;
	}

	if(entry.last_write_time() > metaFileEntry.last_write_time())
	{
		return true;
	}
	
	return false;
}

void ResourcesManager::ImportAsset(const fs::directory_entry& entry)
{
	auto assetLoader = AssetLoaderFactory::CreateLoader(entry);
	assetLoader->CreateAssetMetaFile();
}

