#pragma once
#include <map>
#include <memory>
#include <string>
#include <filesystem>

namespace fs = std::filesystem;

class BaseAssetLoader
{
public:
	virtual ~BaseAssetLoader() = default;
	BaseAssetLoader(const std::string& path) : filePath(path) {};
	virtual void Load() = 0;
	virtual void CreateAssetMetaFile() = 0;

private:
	std::string filePath;
	
};

template<class T>
class AssetLoader : public BaseAssetLoader
{
	
};

class AssetLoaderFactory
{
public:

	static std::shared_ptr<BaseAssetLoader> Create(const fs::directory_entry& entry);

private:
	
};