#include "MeshObject.h"

#include "assimp/Importer.hpp"
#include "assimp/scene.h"
#include "assimp/postprocess.h"


std::vector<std::string> MeshObject::ext{ ".fbx", ".obj"};

std::shared_ptr<Mesh> MeshObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);
	
	BaseAssetObject<Mesh>::Transfer(read);

	assetPtr = std::make_shared<Mesh>();
	if(!InitMesh(filePath, *assetPtr))
	{
		assetPtr.reset();
		return nullptr;
	}
	return assetPtr;
}

bool MeshObject::InitMesh(const std::string& filePath, Mesh& mesh)
{
	Assimp::Importer importer;

	const aiScene* scene = importer.ReadFile(filePath,
		aiProcess_CalcTangentSpace |
		aiProcess_Triangulate |
		aiProcess_JoinIdenticalVertices |
		aiProcess_SortByPType);

	if(!scene)
	{
		RE_LOG_ERROR("Assets", "Load Mesh {0} failed.. scene is null", filePath.c_str());
		return false;
	}

	return true;
}
