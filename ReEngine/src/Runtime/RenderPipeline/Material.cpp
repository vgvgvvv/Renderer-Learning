#include "Material.h"

DEFINE_DRIVEN_CLASS_IMP(Material, BaseObject)

std::shared_ptr<Material> Material::CreateDefault(const std::string& filePath)
{
	auto mat = std::make_shared<Material>();
	mat->vertexShaderPath = "Default/Unlit.vert.glsl";
	mat->fragmentShaderPath = "Default/Unlit.frag.glsl";
	return mat;
}
