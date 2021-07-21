#pragma once

#include <vector>

#include "RHI_API.h"
#include "Vector4.h"
#include "Vector3.h"
#include "Vector2.h"

static const int MaxUVNum = 4;

class MeshVertex
{
public:
	Vector3 Position;
	Vector2 UVs[MaxUVNum];
};

class Mesh
{
public:

	std::vector<uint32_t> Indices;
	std::vector<MeshVertex> Vertexes;
};