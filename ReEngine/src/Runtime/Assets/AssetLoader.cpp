#include "AssetLoader.h"


std::shared_ptr<BaseAssetLoader> AssetLoaderFactory::Create(const fs::directory_entry& entry)
{
	auto extension = entry.path().extension();

	return nullptr;
}
