#pragma once
#include <string>
#include "Singleton.h"
#include "Assets_API.h"
#include <filesystem>

namespace fs = std::filesystem;

class Assets_API ResourcesManager
{
	DEFINE_SINGLETON(ResourcesManager);
public:

	template<class T>
	T& Load(const std::string& fileName);

private:
	void CheckImport(const std::string& root = "");
	bool CheckIfAssetNeedImport(const fs::path& path);
	void ImportAsset(const fs::path& path);
};


template <class T>
T& ResourcesManager::Load(const std::string& fileName)
{
	
}
