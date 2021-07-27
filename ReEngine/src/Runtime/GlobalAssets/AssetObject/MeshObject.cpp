#include "MeshObject.h"


#include "Misc/Path.h"


std::vector<std::string> MeshObject::ext{ ".fbx", ".obj"};

std::shared_ptr<MeshGroup> MeshObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);
	
	Transfer(read);

	assetPtr = std::make_shared<MeshGroup>();
	assetPtr->InitFromFile(filePath);
	
	return assetPtr;
}

