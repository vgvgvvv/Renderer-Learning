#pragma once
#include <string>
#include <vector>


#include "Properties.h"
#include "ShaderLab_API.h"
#include "SubShader.h"


class ShaderLab_API ShaderLab
{
public:
	ShaderLab(const std::string& filePath) : filePath(filePath)
	{
	}

	void Compile();
private:
	void ProcessShader();
	void ProcessProperties();
	void ProcessSubShader();

private:
	PropertyGroup propertyGroup;
	std::vector<SubShader> subShaders;
	std::string filePath;
};
