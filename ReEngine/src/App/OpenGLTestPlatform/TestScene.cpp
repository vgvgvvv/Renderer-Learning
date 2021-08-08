#include "TestScene.h"



#include "Camera.h"
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

	auto cube = World::Get().CreateGameObject("Cube");
	auto renderer = cube->AddComponent<MeshRenderer>();
	cube->GetTransform().set_position(Vector3(0, 0, -3));
	
	auto cubeAsset = ResourcesManager::Get().Load("models/cube.fbx").GetPtr<MeshGroup>();
	renderer->SetMesh(cubeAsset->meshes[0]);

	auto materialAsset = ResourcesManager::Get().Load("materials/DefaultMat.mat").GetPtr<Material>();
	renderer->AddMaterial(materialAsset);

	cube->AddComponent<RotationComponent>();
	
}

void TestScene::OnShutDown()
{
}
