#include "Misc/Path.h"
#include "ResourceManager.h"


void ResourcesManager::CheckImport(const std::string& root)
{
	auto targetPath = root;
	if(targetPath == "")
	{
		targetPath = Path::GetResourcesPath();
	}

	for (const auto& entry : fs::directory_iterator(targetPath))
	{
		if(entry.path().extension() == "meta")
		{
			continue;
		}
		if(entry.is_directory())
		{
			CheckImport(entry.path().string());
			continue;
		}
		else
		{
			if(CheckIfAssetNeedImport(entry))
			{
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
	
}
