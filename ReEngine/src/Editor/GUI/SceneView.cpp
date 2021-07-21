#include "SceneView.h"
#include "Camera.h"
#include "imgui.h"
#include "RenderTexture.h"
#include "Renderer/Texture.h"

void SceneView::OnInit()
{
	camera = std::make_shared<Camera>();
	camera->Awake();

	camera->SetRenderTexture(showTexture);
}

void SceneView::OnGUI()
{
	
}
		
	

void SceneView::ShutDown()
{
	camera->BeginDestroy();
}
