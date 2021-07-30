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
	camera->GetTransform().set_position(Vector3(0, 0, -1));

	auto cube = World::Get().CreateGameObject("Cube");
	auto renderer = cube->AddComponent<MeshRenderer>();
	cube->GetTransform().set_position(Vector3(0, 0, 1));
	
	auto cubeAsset = ResourcesManager::Get().Load("models/cube.fbx").GetPtr<MeshGroup>();
	renderer->SetMesh(cubeAsset->meshes[0]);

	auto materialAsset = ResourcesManager::Get().Load("materials/default.mat").GetPtr<Material>();
	renderer->AddMaterial(materialAsset);

}

void TestScene::OnShutDown()
{
}
