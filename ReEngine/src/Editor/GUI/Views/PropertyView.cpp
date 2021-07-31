#include "PropertyView.h"

#include "Component.h"
#include "EditorContext.h"
#include "GameObject.h"
#include "imgui.h"
#include "imgui_stdlib.h"
#include "Transfer/ImGuiTransfer.h"

static std::string title = "Property";
const std::string& PropertyView::GetTitle() const
{
	return title;
}

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

	for (auto& component : showObject->GetComponents())
	{
		if (ImGui::CollapsingHeader(component->ClassName().c_str(), ImGuiTreeNodeFlags_DefaultOpen))
		{
			DrawComponent(component);
		}
	}
}

void PropertyView::DrawComponent(std::shared_ptr<Component> component)
{
	ImGui::Text("Draw %s", component->ClassName().c_str());
	
	ImGuiTransfer transfer;
	component->TransferImGui(transfer);
	
}


