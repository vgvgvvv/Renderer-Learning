#include "SceneView.h"
#include "Camera.h"
#include "imgui.h"

void SceneView::OnInit()
{
	camera = std::make_shared<Camera>();
	camera->Awake();
}

void SceneView::OnGUI()
{
	ImGui::Text("asdq");
}

void SceneView::ShutDown()
{
	camera->BeginDestroy();
}
