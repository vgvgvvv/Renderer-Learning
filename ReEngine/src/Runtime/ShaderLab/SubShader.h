#pragma once

#include <string>
#include <vector>

#include "ShaderLab_API.h"

class ShaderLab_API ShaderPass
{
public:
	std::string vertexSource;
	std::string fragmentSource;
};

class ShaderLab_API SubShader
{
public:
	std::vector<ShaderPass> passes;
};
