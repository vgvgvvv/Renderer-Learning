#include "PrefabObject.h"

std::vector<std::string> PrefabObject::ext{ ".prefab"};


std::shared_ptr<GameObject> PrefabObject::Load(const std::string& filePath)
{
	BaseAssetObject<GameObject>::Load(filePath);
	// TODO
}
