#pragma once

#include <memory>
#include <string>
#include <vector>

#include "ClassInfo.h"
#include "AssetsClassDefine.h"
#include "Color.h"
#include "RenderPipeline_API.h"
#include "Vector3.h"
#include "Vector2.h"

static const int MaxUVNum = 4;

struct MeshVertex
{
	Vector3 position;
	Color color;
	Vector3 normal;
	Vector2 uv0;
};

struct Mesh
{
	std::vector<uint32_t> Indices;
	std::vector<MeshVertex> vertexes;
};

struct RenderPipeline_API MeshGroup
{
	DEFINE_CLASS(MeshGroup, void);
	DEFINE_IMPORT_ASSET_CLASS(MeshGroup)
public:
	std::vector<std::shared_ptr<Mesh>> meshes;
	bool InitFromFile(const std::string& filePath);
private:
	void ProcessNode(class aiNode* node, const class aiScene* scene);
	std::shared_ptr<Mesh> ProcessMesh(class aiMesh* mesh, const aiScene* scene);
};

template <class TransferFunction>
void MeshGroup::TransferImportSetting(TransferFunction& transferFunc)
{
}

