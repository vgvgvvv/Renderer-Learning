#include "Scene.h"

DEFINE_DRIVEN_CLASS_IMP(Scene, BaseObject)

std::shared_ptr<Scene> Scene::CreateDefault(const std::string& filePath)
{
	return std::make_shared<Scene>();
}
