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
		if(entry.is_directory())
		{
			CheckImport(entry.path().string());
			continue;
		}
		else
		{
			if(CheckIfAssetNeedImport(entry.path()))
			{
				ImportAsset(entry.path());
			}
		}
	}
	
}

bool ResourcesManager::CheckIfAssetNeedImport(const fs::path& path)
{
	// TODO
	return true;
}

void ResourcesManager::ImportAsset(const fs::path& path)
{
	// TODO
}
