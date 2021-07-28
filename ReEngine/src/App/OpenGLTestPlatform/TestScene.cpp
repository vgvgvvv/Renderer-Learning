#include "TestScene.h"



#include "Camera.h"
#include "RendererComponents/CubeRenderer.h"
#include "ResourceManager.h"
#include "World.h"
#include "Components/Transform.h"

void TestScene::OnInit()
{
	auto camera = World::Get().CreateGameObject("Camera");
	camera->AddComponent<Camera>();
	camera->GetTransform().position = Vector3(0, 0, -1);

	auto cube = World::Get().CreateGameObject("Cube");
	auto renderer = cube->AddComponent<MeshRenderer>();
	cube->GetTransform().position = Vector3(0, 0, 1);
	
	auto cubeAsset = ResourcesManager::Get().Load("models/cube.fbx").Get<MeshGroup>();
}

void TestScene::OnShutDown()
{
}
