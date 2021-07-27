#include "MeshObject.h"


#include "Misc/Path.h"


std::vector<std::string> MeshObject::ext{ ".fbx", ".obj"};

std::shared_ptr<MeshGroup> MeshObject::Load(bool onlyMetaInfo)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);
	
	Transfer(read);

	if(!onlyMetaInfo)
	{
		assetPtr = std::make_shared<MeshGroup>();
		assetPtr->InitFromFile(filePath);

		return assetPtr;
	}
	
	return nullptr;
}

