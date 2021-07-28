#include "Mesh.h"
#include "assimp/Importer.hpp"
#include "assimp/scene.h"
#include "assimp/postprocess.h"
#include "Logging/Log.h"

bool MeshGroup::InitFromFile(const std::string& filePath)
{

	Assimp::Importer importer;
	const aiScene* scene = importer.ReadFile(filePath.c_str(),
		aiProcess_CalcTangentSpace |
		aiProcess_Triangulate |
		aiProcess_JoinIdenticalVertices |
		aiProcess_SortByPType);
	
	if (!scene || scene->mFlags & AI_SCENE_FLAGS_INCOMPLETE || !scene->mRootNode)
	{
		RE_LOG_ERROR("Assets", "Load Mesh {0} failed.. scene is null", filePath.c_str());
		return false;
	}
	
	ProcessNode(scene->mRootNode, scene);

	return true;
}


void MeshGroup::ProcessNode(aiNode* node, const aiScene* scene)
{
	for (int i = 0; i < node->mNumMeshes; i++)
	{
		aiMesh* mesh = scene->mMeshes[node->mMeshes[i]];
		meshes.push_back(ProcessMesh(mesh, scene));
	}
}

std::shared_ptr<Mesh> MeshGroup::ProcessMesh(aiMesh* mesh, const aiScene* scene)
{
	std::vector<uint32_t> Indices;
	std::vector<MeshVertex> vertexes;

	for (int i = 0; i < mesh->mNumVertices; i++)
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
	
	for (int i = 0; i < mesh->mNumFaces; i++)
	{
		auto& face = mesh->mFaces[i];
		for (int i2 = 0; i2 < face.mNumIndices; i2++)
		{
			Indices.push_back(face.mIndices[i2]);
		}
	}

	return std::make_shared<Mesh>(Indices, vertexes);
}


std::shared_ptr<MeshGroup> MeshGroup::CreateDefault(const std::string& filePath)
{
	return std::make_shared<MeshGroup>();
}

std::shared_ptr<MeshGroup> MeshGroup::Load(const std::string& filePath)
{
	auto meshGroup = std::make_shared<MeshGroup>();
	meshGroup->InitFromFile(filePath);
	return meshGroup;
}

