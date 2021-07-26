#pragma once
#include <string>
#include "Singleton.h"
#include "GlobalAssets_API.h"
#include <filesystem>
#include <map>
#include "inifile.h"

#include "uuid.h"


namespace fs = std::filesystem;

class GlobalAssets_API ResourcesManager
{
	DEFINE_SINGLETON(ResourcesManager);
public:

	template<class T>
	T& Load(const std::string& fileName);

	void CheckImport(const std::string& root);

private:
	bool CheckIfAssetNeedImport(const fs::directory_entry& entry);
	void ImportAsset(const fs::directory_entry& entry);

private:
	std::map<uuids::uuid, std::shared_ptr<class BaseAssetObject>> resourcesMap;
};



