#include "SceneView.h"
#include "Camera.h"
#include "imgui.h"
#include "Renderer/Texture.h"

void SceneView::OnInit()
{
	camera = std::make_shared<Camera>();
	camera->Awake();

	showTexture = std::make_shared<Texture>("D:\\test.png");
}

void SceneView::OnGUI()
{
	ImVec2 vMin = ImGui::GetWindowContentRegionMin();
	ImVec2 vMax = ImGui::GetWindowContentRegionMax();

	vMin.x += ImGui::GetWindowPos().x;
	vMin.y += ImGui::GetWindowPos().y;
	vMax.x += ImGui::GetWindowPos().x;
	vMax.y += ImGui::GetWindowPos().y;

	ImGui::GetWindowDrawList()->AddImage((ImTextureID)showTexture->GetRenderId(), vMin, vMax);
}
		
	

void SceneView::ShutDown()
{
	camera->BeginDestroy();
}
