#pragma once
#include <map>
#include <memory>
#include <string>
#include <filesystem>
#include "GlobalAssets_API.h"
#include "Logging/Log.h"
#include "Transfer/JsonTransfer.h"

namespace fs = std::filesystem;

class GlobalAssets_API BaseAssetLoader
{
public:
	virtual ~BaseAssetLoader() = default;
	BaseAssetLoader(const std::string& path) : filePath(path) {};
	virtual void Load() = 0;
	virtual void CreateAssetMetaFile() = 0;


protected:
	std::string filePath;
	
};

template<class T>
class GlobalAssets_API AssetLoader : public BaseAssetLoader
{
public:
	AssetLoader(const std::string& path) : BaseAssetLoader(path) {};


	void Load() override
	{
		if (!assetPtr)
		{
			assetPtr = std::make_shared<T>();
		}
		assetPtr->Load(filePath);
	}
	
	void CreateAssetMetaFile() override
	{
		RE_LOG_INFO("Asset", "Create Asset Meta File {0}", filePath.c_str());

		std::string metaFilePath(filePath + ".meta");
		JsonWrite writer(metaFilePath);

		if(!assetPtr)
		{
			assetPtr = std::make_shared<T>();
		}
		assetPtr->Transfer(writer);
		writer.Save();
	}

protected:
	std::shared_ptr<T> assetPtr;
};

class GlobalAssets_API AssetLoaderFactory
{
public:
	static std::shared_ptr<BaseAssetLoader> CreateLoader(const fs::directory_entry& entry);

private:
	template<class T>
	static std::shared_ptr<BaseAssetLoader> Create(const fs::directory_entry& entry)
	{
		const auto filePath = entry.path().string();

		return std::make_shared<AssetLoader<T>>(filePath);
	}

	
};