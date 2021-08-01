#include "Mesh.h"
#include "assimp/scene.h"
#include "assimp/postprocess.h"
#include "assimp/Importer.hpp"
#include "Common.h"

DEFINE_DRIVEN_CLASS_IMP(MeshGroup, BaseObject)

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
	for(int i = 0; i < node->mNumChildren; i ++)
	{
		ProcessNode(node->mChildren[i], scene);
	}
}

std::shared_ptr<Mesh> MeshGroup::ProcessMesh(aiMesh* mesh, const aiScene* scene)
{
	std::vector<uint32_t> Indices;
	std::vector<MeshVertex> vertexes;

	Vector3 finalPosition;
	Color finalColor = Color::gray;
	Vector3 finalNormal;
	Vector2 finalUV0 = Vector2::zeroVector;
	
	for (int i = 0; i < mesh->mNumVertices; i++)
	{
		auto& position = mesh->mVertices[i];
		finalPosition = Vector3(position.x, position.y, position.z);
		
		auto color = mesh->mColors[0];
		if(color != nullptr)
			finalColor = Color(color->r, color->g, color->b, color->a);
		
		auto& normal = mesh->mNormals[i];
		finalNormal = Vector3(normal.x, normal.y, normal.z);
		
		auto uv0 = mesh->mTextureCoords[0];
		if(uv0 != nullptr)
			finalUV0 = Vector2(uv0->x, uv0->y);
	
		MeshVertex vertex{
			finalPosition,
			finalColor,
			finalNormal,
			finalUV0
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

