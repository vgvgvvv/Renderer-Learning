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
	Vector2 uvs[MaxUVNum];
};

struct MeshSurface
{
	std::vector<uint32_t> Indices;
};

struct Mesh
{
	MeshSurface surface;
	std::vector<MeshVertex> vertexes;
};

class RHI_API MeshLoader
{
public:
	std::shared_ptr<Mesh> LoadMesh(const std::string& fileName);
};