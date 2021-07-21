#include "TestScene.h"


#include "Camera.h"
#include "RendererComponents/CubeRenderer.h"
#include "World.h"
#include "Transform.h"

void TestScene::OnInit()
{
	auto camera = World::Get().CreateGameObject("Camera");
	camera->AddComponent<Camera>();
	camera->GetTransform().position = Vector3(0, 0, -1);

	auto cube = World::Get().CreateGameObject("Cube");
	cube->AddComponent<CubeRenderer>();
	cube->GetTransform().position = Vector3(0, 0, 1);
}

void TestScene::OnShutDown()
{
}
