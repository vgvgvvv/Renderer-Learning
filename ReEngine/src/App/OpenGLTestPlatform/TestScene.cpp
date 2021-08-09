#include "TestScene.h"



#include "Camera.h"
#include "Components/MoveControlComponent.h"
#include "RendererComponents/CubeRenderer.h"
#include "ResourceManager.h"
#include "RotationComponent.h"
#include "World.h"
#include "Components/Transform.h"


void TestScene::OnInit()
{
	auto camera = World::Get().CreateGameObject("Camera");
	camera->AddComponent<Camera>();
	camera->GetTransform().set_position(Vector3(0, 0, 0));
	camera->AddComponent<MoveControlComponent>();

	auto cubeAsset = ResourcesManager::Get().Load("models/cube.fbx").GetPtr<MeshGroup>();
	auto materialAsset = ResourcesManager::Get().Load("materials/DefaultMat.mat").GetPtr<Material>();
	
	auto cube = World::Get().CreateGameObject("Cube");
	cube->AddComponent<RotationComponent>();
	auto renderer = cube->AddComponent<MeshRenderer>();
	renderer->SetMesh(cubeAsset->meshes[0]);
	renderer->AddMaterial(materialAsset);
	cube->GetTransform().set_position(Vector3(1, 0, 3));
	cube->GetTransform().set_scale(Vector3(1, 1, 1));

	auto cube2 = World::Get().CreateGameObject("Cube2");
	cube2->AddComponent<RotationComponent>();
	auto renderer2 = cube2->AddComponent<MeshRenderer>();
	renderer2->SetMesh(cubeAsset->meshes[0]);
	renderer2->AddMaterial(materialAsset);
	cube2->GetTransform().set_position(Vector3(-1, 0, 3));
	cube2->GetTransform().set_scale(Vector3(0.5, 0.5, 0.5));
	
	

	
	
}

void TestScene::OnShutDown()
{
}
