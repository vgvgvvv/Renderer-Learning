#pragma once

#include <vector>

#include "ShaderLab_API.h"


class ShaderLab_API Property
{

};

class ShaderLab_API PropertyGroup
{
public:
	std::vector<Property> properties;
};
