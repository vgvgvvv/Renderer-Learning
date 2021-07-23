#include "Mesh.h"
#include "Common.h"
#include <assimp/Importer.hpp>
#include <assimp/scene.h>
#include <assimp/postprocess.h>

std::shared_ptr<Mesh> MeshLoader::LoadMesh(const std::string& fileName)
{
	Assimp::Importer importer;

	const aiScene* scene = importer.ReadFile(fileName.c_str(), aiProcess_CalcTangentSpace);

	if(!scene)
	{
		RE_LOG_ERROR("RHI", "Failed To Load {}", fileName.c_str());
		return nullptr;
	}


	std::shared_ptr<Mesh> result = std::make_shared<Mesh>();
	
	if(scene->HasMeshes())
	{
		auto meshNum = scene->mNumMeshes;
		for(int i = 0; i < meshNum; i ++)
		{
			auto mesh = *(scene->mMeshes + i);
			for(int a = 0 ; a < mesh->mNumVertices; a ++)
			{
				
			}
		}
	}
	
	return result;
}
