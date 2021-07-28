#include "ResourceManager.h"
#include "AssetLoader/AssetLoader.h"
#include "Config/Config.h"
#include "Logging/Log.h"
#include "Misc/Path.h"


/// <summary>
/// �����ļ�
/// </summary>
/// <param name="fileName">����ļ�·��</param>
/// <returns></returns>
AssetPtr ResourcesManager::Load(const std::string& fileName)
{
	auto fullPath = Path::Combine(Path::GetResourcesPath(), fileName);

	fs::directory_entry entry(fullPath);

	AssetLoader& assetLoader = AssetLoaderFactory::GetLoader(entry);

	auto assetPtr = assetLoader.Load(fullPath);

	if (assetPtr.Valid())
	{
		// ע����Դ��ȫ����Դ��
		resourcesMap.insert(std::pair<uuids::uuid, AssetPtr>(assetPtr.Uuid(), assetPtr));
	}

	return assetPtr;
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
		if (entry.path().extension() != ".meta")
		{
			continue;
		}

		JsonRead read(entry.path().string());
		uuids::uuid uuid;
		read.transfer(&uuid, "uuid");
		
		uuidToFilePathMap.insert_or_assign(uuid, entry.path().string());

		if (entry.is_directory())
		{
			UpdateMetaPathInfo(entry.path().string());
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

// entryΪ����·��
void ResourcesManager::ImportAsset(const fs::directory_entry& entry)
{
	auto assetLoader = AssetLoaderFactory::GetLoader(entry);
	assetLoader.Import(entry.path().string());
}

