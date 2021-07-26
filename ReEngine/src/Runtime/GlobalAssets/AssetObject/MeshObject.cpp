#include "MeshObject.h"

std::vector<std::string> MeshObject::ext{ ".fbx", ".obj"};

void MeshObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);

	Transfer(read);

	assetPtr = Mesh::Load(filePath);
}
