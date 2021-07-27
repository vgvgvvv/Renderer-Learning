#include "PropertyView.h"

#include "EditorContext.h"
#include "imgui.h"
#include "imgui_stdlib.h"
#include "ImGuiTransfer.h"


void PropertyView::OnInit()
{
}

void PropertyView::OnGUI()
{
	DrawSelectedGameObject();
}

void PropertyView::ShutDown()
{
}

void PropertyView::DrawSelectedGameObject()
{
	auto& selectedObject = EditorContext::Get().SelectedGameObjects;
	if(selectedObject.size() != 1)
	{
		return;
	}

	auto showObject = *selectedObject.begin();
	
	std::string name = showObject->GetName();
	ImGui::InputText("Name", &name);
	showObject->SetName(name);

	for (auto component : showObject->GetComponents())
	{
		
	}
}
