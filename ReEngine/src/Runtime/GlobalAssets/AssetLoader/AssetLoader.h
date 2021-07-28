#pragma once
#include <map>
#include <memory>
#include <string>
#include <filesystem>


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
		JsonRead read(filePath + ".mata");
		
		std::shared_ptr<T> result = T::Load(filePath);
	}
	
	void Import(const std::string& filePath) override
	{
		JsonWrite write(filePath + ".mata");
		
	}

	template<class TransferFunction>
	void TransferMetaFile(const TransferFunction& transfer)
	{
		
	}
};

template<class T>
class ImportAssetLoader : public AssetLoader
{
public:
	ImportAssetLoader(const std::vector<std::string>& exts) : AssetLoader(exts) {}
	AssetPtr Load(const std::string& filePath) override
	{
		return AssetPtr();
	}
	
	void Import(const std::string& filePath) override
	{
		JsonWrite write(filePath + ".mata");
		
	}

	template<class TransferFunction>
	void TransferMetaFile(const TransferFunction& transfer)
	{
		
	}
};

class GlobalAssets_API AssetLoaderFactory
{
public:
	static AssetLoader& GetLoader(const fs::directory_entry& entry);
};
