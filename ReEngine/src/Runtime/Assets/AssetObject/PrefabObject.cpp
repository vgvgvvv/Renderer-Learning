#include "PrefabObject.h"

std::vector<std::string> PrefabObject::ext{ ".prefab"};


void PrefabObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);

	assetPtr = GameObject::Load(filePath);
}
