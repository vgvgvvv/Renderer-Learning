#include "SceneView.h"
#include "Camera.h"
#include "GameObject.h"
#include "imgui.h"
#include "RenderContext.h"
#include "RenderTexture.h"
#include "Renderer/Texture.h"

void SceneView::OnInit()
{
	cameraObj = GameObject::CreateGameObject("SceneView Camera", GameObjectFlag::HideAndNotSave);
	camera = cameraObj->AddComponent<Camera>();

	showTexture = std::make_shared<RenderTexture>(1280, 720);
	
	camera->SetRenderTexture(showTexture);
}

void SceneView::OnGUI()
{
	ImVec2 vMin = ImGui::GetWindowContentRegionMin();
	ImVec2 vMax = ImGui::GetWindowContentRegionMax();
	
	vMin.x += ImGui::GetWindowPos().x;
	vMin.y += ImGui::GetWindowPos().y;
	vMax.x += ImGui::GetWindowPos().x;
	vMax.y += ImGui::GetWindowPos().y;
	
	ImGui::GetWindowDrawList()->AddImage((ImTextureID)showTexture->GetTexture().GetRenderId(), vMin, vMax);
}
		
	

void SceneView::ShutDown()
{
	GameObject::Destroy(cameraObj);
}
