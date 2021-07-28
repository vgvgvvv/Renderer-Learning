#pragma once
#include <map>
#include <memory>
#include <string>
#include <filesystem>

#include "uuid.h"
#include "CommonExt.h"
#include "GlobalAssets_API.h"
#include "Logging/Log.h"
#include "Transfer/JsonTransfer.h"

class Material;
class GameObject;
class MeshObject;
class TextureObject;
namespace fs = std::filesystem;


class GlobalAssets_API AssetPtr
{
public:

	template<class T>
	static AssetPtr Create(const std::string& filePath, std::shared_ptr<T> asset)
	{
		AssetPtr ptr;
		ptr.filePath = filePath;
		ptr.uuid = asset->Uuid();
		ptr.assetPtr = std::static_pointer_cast<T>(asset);
		return ptr;
	}
	
	const uuids::uuid& Uuid() const { return uuid; }
	
	template<class T>
	T& Get() const { return *std::static_pointer_cast<T>(assetPtr); }

	template<class T>
	bool TryGet(T* out){
		if(!Valid())
		{
			return false;
		}
		out = std::static_pointer_cast<T>(assetPtr).get();
		return true;
	}
	
	bool Valid() const
	{
		return assetPtr != nullptr;
	}
private:
	uuids::uuid uuid;
	std::string filePath;
	std::shared_ptr<void> assetPtr = nullptr;
};

class GlobalAssets_API AssetLoader
{
public:
	AssetLoader(const std::vector<std::string>& exts) : exts(exts){}
	virtual ~AssetLoader() = default;

	virtual AssetPtr Load(const std::string& filePath);

	virtual void Import(const std::string& filePath);

	static AssetLoader& DefaultLoader();

	bool HasExt(const std::string& ext)
	{
		return std::find(exts.begin(), exts.end(), ext) != exts.end();
	}
	
protected:
	std::vector<std::string> exts;
};

template<class T>
class NormalAssetLoader : public AssetLoader
{
public:
	NormalAssetLoader(const std::vector<std::string>& exts) : AssetLoader(exts) {}
	AssetPtr Load(const std::string& filePath) override
	{
		std::shared_ptr<T> result = T::Load(filePath);

		return AssetPtr::Create(filePath, result);
	}
	
	void Import(const std::string& filePath) override
	{
		JsonWrite write(filePath + ".mata");
		T::TransferDefault(write);
		write.Save();
	}


};

template<class T>
class ImportAssetLoader : public AssetLoader
{
public:
	ImportAssetLoader(const std::vector<std::string>& exts) : AssetLoader(exts) {}
	AssetPtr Load(const std::string& filePath) override
	{
		std::shared_ptr<T> result = T::Load(filePath);
		return AssetPtr::Create(filePath, result);
	}
	
	void Import(const std::string& filePath) override
	{
		JsonWrite write(filePath + ".mata");
		T::TransferDefault(write);
		write.Save();
	}

};

class GlobalAssets_API AssetLoaderFactory
{
public:
	static AssetLoader& GetLoader(const fs::directory_entry& entry);
};
