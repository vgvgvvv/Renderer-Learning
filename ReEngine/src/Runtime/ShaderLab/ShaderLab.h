#pragma once
#include <string>
#include <vector>

#include "ShaderLab_API.h"

enum class ShaderType
{
	Vertex,
	Fragment
};

class ShaderLab_API SubShader
{
public:
	ShaderType type;
	std::string source;
};

class ShaderLab_API ShaderLab
{
public:
	ShaderLab(const std::string& filePath) : filePath(filePath)
	{
	}

	void Compile();

private:
	std::vector<SubShader> subShaders;
	std::string filePath;
};
