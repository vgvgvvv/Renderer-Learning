#pragma once

#include <vector>

#include "RHI_API.h"
#include "Vector4.h"

class MeshVertex
{
public:
	Vector4 Position;
};

class Mesh
{
public:

	std::vector<uint32_t> Indices;
	std::vector<MeshVertex> Vertexes;
};