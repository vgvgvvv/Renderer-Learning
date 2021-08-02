#include "ResourceManager.h"
#include "AssetLoader/AssetLoader.h"
#include "Config/Config.h"
#include "Logging/Log.h"
#include "Misc/Path.h"
#include "Class.h"

void ResourcesManager::InitSingleton()
{
}


/// <summary>
/// 加载文件
/// </summary>
/// <param name="fileName">相对文件路径</param>
/// <returns></returns>
AssetPtr& ResourcesManager::Load(const std::string& fileName)
{
	auto fullPath = Path::Combine(Path::GetResourcesPath(), fileName);

	fs::directory_entry entry(fullPath);

	AssetLoader& assetLoader = AssetLoaderFactory::GetLoader(entry);

	// 尝试从缓存中找到
	for (auto& resoucePair : resourcesMap)
	{
		auto& assetPtr = resoucePair.second;
		if(!assetPtr.Valid())
			continue;
		if(assetPtr.LoadFrom() == fullPath)
		{
			return assetPtr;
		}
	}

	auto assetPtr = assetLoader.Load(fullPath);

	if (assetPtr.Valid())
	{
		// 注册资源到全局资源表
		resourcesMap.insert(std::pair<uuids::uuid, AssetPtr>(assetPtr.Uuid(), assetPtr));
	}

	return resourcesMap[assetPtr.Uuid()];
}

void ResourcesManager::Save(const AssetPtr& assetPtr)
{
	AssetLoader& assetLoader = AssetLoaderFactory::GetLoaderWithType(assetPtr.GetType()->Name());
	assetLoader.Save(assetPtr.filePath, assetPtr.GetPtr<void>());
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

void ResourcesManager::UpdateMetaPathInfo(const std::string& root)
{
	std::string targetPath = root;

	if (!fs::exists(root))
	{
		RE_LOG_WARN("Resources", "Cannot find directory : {0}", root.c_str());
		return;
	}
	
	for (const auto& entry : fs::directory_iterator(targetPath))
	{
		if (entry.path().extension() == ".meta")
		{
			JsonRead read(entry.path().string());
			uuids::uuid uuid;
			read.transfer(&uuid, "uuid");

			auto metaFilePath = entry.path().string();
			auto filePath = metaFilePath.substr(0, metaFilePath.size() - strlen(".meta"));
			uuidToFilePathMap.insert_or_assign(uuid, filePath);
			
		}
		else
		{
			if (entry.is_directory())
			{
				UpdateMetaPathInfo(entry.path().string());
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

	return false;
}

// entry为完整路径
void ResourcesManager::ImportAsset(const fs::directory_entry& entry)
{
	auto& assetLoader = AssetLoaderFactory::GetLoader(entry);
	assetLoader.Import(entry.path().string());
}

