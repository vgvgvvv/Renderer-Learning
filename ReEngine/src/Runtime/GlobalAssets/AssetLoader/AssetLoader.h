#pragma once
#include <any>
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
	std::shared_ptr<T> GetPtr() const { return std::static_pointer_cast<T>(assetPtr); }

	template<class T>
	bool TryGet(T* out){
		if(!Valid())
		{
			return false;
		}
		out = std::static_pointer_cast<T>(assetPtr).get();
		return true;
	}

	const std::string& LoadFrom() { return filePath; };
	
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

	virtual void Save(const std::string& filePath, std::shared_ptr<void> asset);

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
		// 创建默认数据
		std::shared_ptr<T> asset = T::CreateDefault(filePath);

		// 仅储存 uuid
		JsonRead metaRead(filePath + ".meta");
		metaRead.transfer(&asset->uuid, "uuid");

		// 读取数据
		JsonRead assetRead(filePath);
		asset->TransferAsset(assetRead);
		
		return AssetPtr::Create(filePath, asset);
	}
	
	void Import(const std::string& filePath) override
	{
		// 仅储存 uuid
		JsonWrite metaWrite(filePath + ".meta");
		auto uuid = uuids::uuid_system_generator{}();
		metaWrite.transfer(&uuid, "uuid");
		metaWrite.Save();

		std::shared_ptr<T> asset = T::CreateDefault(filePath);
		JsonWrite assetWrite(filePath);
		asset->TransferAsset(assetWrite);
		assetWrite.Save();
	}

	void Save(const std::string& filePath, std::shared_ptr<void> asset) override
	{
		auto assetT = std::static_pointer_cast<T>(asset);

		// 写入资源
		JsonWrite write(filePath);
		assetT->TransferAsset(write);

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
		// 加载二进制数据
		std::shared_ptr<T> result = T::Load(filePath);

		// 加载导入选项
		JsonRead metaRead(filePath + ".meta");
		metaRead.transfer(&result->uuid, "uuid");
		result->TransferImportSetting(metaRead);

		return AssetPtr::Create(filePath, result);
	}
	
	void Import(const std::string& filePath) override
	{
		// 创建默认数据
		std::shared_ptr<T> asset = T::CreateDefault(filePath);

		// 写入导入选项
		JsonWrite metaWrite(filePath + ".meta");
		asset->uuid = uuids::uuid_system_generator{}();
		metaWrite.transfer(&asset->uuid, "uuid");
		asset->TransferImportSetting(metaWrite);
		
		metaWrite.Save();
	}

	void Save(const std::string& filePath, std::shared_ptr<void> asset) override
	{
		auto assetT = std::static_pointer_cast<T>(asset);

		// 写入导入选项
		JsonWrite metaWrite(filePath + ".meta");
		metaWrite.transfer(&assetT->uuid, "uuid");
		assetT->TransferImportSetting(metaWrite);

		metaWrite.Save();
	}
};

class GlobalAssets_API AssetLoaderFactory
{
public:
	static AssetLoader& GetLoader(const fs::directory_entry& entry);
	
	static AssetLoader& GetLoaderWithType(const std::string& className);
};
