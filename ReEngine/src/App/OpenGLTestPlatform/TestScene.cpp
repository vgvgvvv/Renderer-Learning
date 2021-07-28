#include "TestScene.h"



#include "AssetObject/DefaultAssetObject.h"
#include "AssetObject/MeshObject.h"
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
	
	auto& cubeAsset = ResourcesManager::Get().Load<MeshObject>("models/cube.fbx");
	renderer->SetMesh(cubeAsset.Get().meshes[0]);
	auto& materialAsset = ResourcesManager::Get().Load<DefaultAssetObject<Material>>("mats/test.mat");

}

void TestScene::OnShutDown()
{
}
