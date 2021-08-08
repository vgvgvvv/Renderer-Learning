#pragma once

#include <memory>
#include <string>
#include <vector>

#include "ClassInfo.h"
#include "AssetsClassDefine.h"
#include "BaseObject.h"
#include "Color.h"
#include "RenderPipeline_API.h"
#include "Vector3.h"
#include "Vector2.h"

static const int MaxUVNum = 4;

struct Mesh
{
	std::vector<uint32_t> indices;
	std::vector<Vector3> vertexes;
	std::vector<Color> colors;
	std::vector<Vector3> normals;
	std::vector<Vector2> uv0;
};

struct RenderPipeline_API MeshGroup : public BaseObject
{
	DEFINE_DRIVEN_CLASS(MeshGroup, BaseObject);
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

