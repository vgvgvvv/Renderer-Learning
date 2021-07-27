#include "TestScene.h"



#include "AssetObject/MeshObject.h"
#include "Camera.h"
#include "RendererComponents/CubeRenderer.h"
#include "ResourceManager.h"
#include "World.h"
#include "Transform.h"

void TestScene::OnInit()
{
	auto camera = World::Get().CreateGameObject("Camera");
	camera->AddComponent<Camera>();
	camera->GetTransform().position = Vector3(0, 0, -1);

	auto cube = World::Get().CreateGameObject("Cube");
	cube->AddComponent<MeshRenderer>();
	cube->GetTransform().position = Vector3(0, 0, 1);

	auto& cubeAsset = ResourcesManager::Get().Load<MeshObject>("models/cube.fbx");
}

void TestScene::OnShutDown()
{
}
