#pragma once
#include <map>
#include <memory>
#include <string>
#include <filesystem>
#include "Assets_API.h"
#include "Logging/Log.h"
#include "Transfer/JsonTransfer.h"

namespace fs = std::filesystem;

class Assets_API BaseAssetLoader
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
class Assets_API AssetLoader : public BaseAssetLoader
{
public:
	AssetLoader(const std::string& path) : BaseAssetLoader(path) {};


	void Load() override
	{
		
	}
	
	void CreateAssetMetaFile() override
	{
		RE_LOG_INFO("Asset", "Create Asset Meta File {0}", filePath.c_str());

		std::string metaFilePath(filePath + ".meta");
		JsonWrite writer(metaFilePath);

		std::shared_ptr<T> asset = std::make_shared<T>();
		asset->Transfer(writer);
		writer.Save();

	}
	

protected:
	std::shared_ptr<T> assetPtr;
};

class Assets_API AssetLoaderFactory
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