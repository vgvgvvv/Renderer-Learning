#include "PrefabObject.h"

std::vector<std::string> PrefabObject::ext{ ".prefab"};


std::shared_ptr<GameObject> PrefabObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	BaseAssetObject<GameObject>::Transfer(read);
	
	assetPtr = std::make_shared<GameObject>();
	// TODO
	return assetPtr;
}
