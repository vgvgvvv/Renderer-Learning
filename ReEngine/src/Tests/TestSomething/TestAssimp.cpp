#include "TestAssimp.h"
#include "assimp/Importer.hpp"
#include "assimp/postprocess.h"
#include "assimp/scene.h"
#include "Logging/Log.h"
#include "Misc/Path.h"


void TestAssimp::TestImport()
{
	auto resourcePath = Path::Combine(Path::GetResourcesPath(), "models/cube.fbx");

	Assimp::Importer importer;
	const aiScene* scene = importer.ReadFile(resourcePath.c_str(),
		aiProcess_CalcTangentSpace |
		aiProcess_Triangulate |
		aiProcess_JoinIdenticalVertices |
		aiProcess_SortByPType);

	auto mesh = scene->mMeshes[0];
	for (int i = 0; i < mesh->mNumVertices; i++)
	{
		auto vertex = mesh->mVertices[i];
		RE_LOG_INFO("Test", "Vertex{0} : {1} {2} {3}", i, vertex.x, vertex.y, vertex.z);
	}
}
