#include "MeshObject.h"

std::vector<std::string> MeshObject::ext{ ".fbx", ".obj"};

std::shared_ptr<Mesh> MeshObject::Load(const std::string& filePath)
{
	BaseAssetObject<Mesh>::Load(filePath);
	// TODO
}
