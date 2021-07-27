#include "PrefabObject.h"

std::vector<std::string> PrefabObject::ext{ ".prefab"};


std::shared_ptr<GameObject> PrefabObject::Load( bool onlyMetaInfo)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);

	if(!onlyMetaInfo)
	{
		assetPtr = std::make_shared<GameObject>();
		// TODO
		return assetPtr;
	}
	return nullptr;
}
