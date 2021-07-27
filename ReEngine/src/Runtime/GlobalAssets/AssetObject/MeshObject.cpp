#include "MeshObject.h"

#include "assimp/Importer.hpp"
#include "assimp/scene.h"
#include "assimp/postprocess.h"


std::vector<std::string> MeshObject::ext{ ".fbx", ".obj"};

std::shared_ptr<MeshGroup> MeshObject::Load(const std::string& filePath)
{
	std::string metaFilePath(filePath + ".meta");
	JsonRead read(metaFilePath);
	
	Transfer(read);

	assetPtr = std::make_shared<MeshGroup>();
	if(!InitMesh(filePath, *assetPtr))
	{
		assetPtr.reset();
		return nullptr;
	}
	return assetPtr;
}

bool MeshObject::InitMesh(const std::string& filePath, MeshGroup& meshGroup)
{
	Assimp::Importer importer;

	const aiScene* scene = importer.ReadFile(filePath,
		aiProcess_CalcTangentSpace |
		aiProcess_Triangulate |
		aiProcess_JoinIdenticalVertices |
		aiProcess_SortByPType);

	if(!scene || scene->mFlags & AI_SCENE_FLAGS_INCOMPLETE || !scene->mRootNode)
	{
		RE_LOG_ERROR("Assets", "Load Mesh {0} failed.. scene is null", filePath.c_str());
		return false;
	}

	ProcessNode(scene->mRootNode, scene);
	
	return true;
}

void MeshObject::ProcessNode(aiNode* node, const aiScene* scene)
{
	for(int i = 0; i < node->mNumMeshes; i ++)
	{
		aiMesh* mesh = scene->mMeshes[node->mMeshes[i]];
		auto& meshGroup = *assetPtr;
		meshGroup.meshes.push_back(ProcessMesh(mesh, scene));
	}
}

Mesh MeshObject::ProcessMesh(aiMesh* mesh, const aiScene* scene)
{
	std::vector<uint32_t> Indices;
	std::vector<MeshVertex> vertexes;

	for(int i = 0; i < mesh->mNumVertices; i ++)
	{
		auto& position = mesh->mVertices[i];
		auto& color = mesh->mColors[0][i];
		auto& normal = mesh->mNormals[i];
		auto& uv0 = mesh->mTextureCoords[0][i];
		
		MeshVertex vertex{
			Vector3(position.x, position.y, position.z),
			Color(color.r, color.g, color.b, color.a),
			Vector3(normal.x, normal.y, normal.z),
			Vector2(uv0.x, uv0.y)
		};

		vertexes.emplace_back(vertex);
	}
	
	for(int i = 0; i < mesh->mNumFaces; i ++)
	{
		auto& face = mesh->mFaces[i];
		for(int i2 = 0; i2 < face.mNumIndices; i2++)
		{
			Indices.push_back(face.mIndices[i2]);
		}
	}

	return Mesh{ Indices, vertexes };
}
