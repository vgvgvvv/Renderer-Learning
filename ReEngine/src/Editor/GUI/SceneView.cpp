#include "SceneView.h"
#include "Camera.h"
#include "GameObject.h"
#include "imgui.h"
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

	auto sceneViewWidth = vMax.x - vMin.x;
	auto sceneViewHeight = vMax.y - vMin.y;

	if(lastWidth != sceneViewWidth || lastHeight != sceneViewHeight)
	{
		camera->SetAspect(sceneViewWidth / sceneViewHeight);
		camera->SetEditorRect(vMin.x, vMin.y, sceneViewWidth, sceneViewHeight);
		showTexture->ReSize(sceneViewWidth, sceneViewHeight);
		lastWidth = sceneViewWidth;
		lastHeight = sceneViewHeight;
	}
	
	ImVec2 vDrawMin = vMin;
	vDrawMin.x += ImGui::GetWindowPos().x;
	vDrawMin.y += ImGui::GetWindowPos().y;
	ImVec2 vDrawMax = vMax;
	vDrawMax.x += ImGui::GetWindowPos().x;
	vDrawMax.y += ImGui::GetWindowPos().y;
	
	ImGui::GetWindowDrawList()->AddImage((ImTextureID)showTexture->GetTexture().GetRenderId(), vDrawMin, vDrawMax);

	
	
}
		
	

void SceneView::ShutDown()
{
	GameObject::Destroy(cameraObj);
}
