#pragma once

#include <memory>
#include <string>
#include <vector>


#include "Color.h"
#include "RHI_API.h"
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

struct RHI_API MeshGroup
{
	std::vector<std::shared_ptr<Mesh>> meshes;
	bool InitFromFile(const std::string& filePath);
private:
	void ProcessNode(class aiNode* node, const class aiScene* scene);
	std::shared_ptr<Mesh> ProcessMesh(class aiMesh* mesh, const aiScene* scene);
};


