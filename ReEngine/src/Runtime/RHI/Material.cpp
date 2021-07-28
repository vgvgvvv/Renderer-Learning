#include "Material.h"

std::shared_ptr<Material> Material::CreateDefault(const std::string& filePath)
{
	auto mat = std::make_shared<Material>();
	mat->vertexShaderPath = "Default/Unlit.vert.glsl";
	mat->fragmentShaderPath = "Default/Unlit.frag.glsl";
	return mat;
}
