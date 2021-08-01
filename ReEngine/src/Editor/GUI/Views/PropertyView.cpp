#include "PropertyView.h"

#include "Component.h"
#include "EditorContext.h"
#include "GameObject.h"
#include "imgui.h"
#include "imgui_stdlib.h"
#include "Transfer/ImGuiTransfer.h"

DEFINE_DRIVEN_CLASS_IMP(PropertyView, IView)
DEFINE_VIEW_IMP(PropertyView, Property)

static std::string CreateComponentPopupID = "PropertyView Create Component";

void PropertyView::OnInit()
{
	Super::OnInit();
}

void PropertyView::OnGUI(float deltaTime)
{
	Super::OnGUI(deltaTime);
	DrawSelectedGameObject();
}

void PropertyView::ShutDown()
{
	Super::ShutDown();
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

	if (ImGui::Button("Create"))
	{
		ImGui::OpenPopup(CreateComponentPopupID.c_str());
	}
	DrawCreateComponent();
}

void PropertyView::DrawComponent(std::shared_ptr<Component> component)
{
	ImGui::Text("Draw %s", component->ClassName().c_str());
	
	ImGuiTransfer transfer;
	component->TransferImGui(transfer);

	
}

void PropertyView::DrawCreateComponent()
{
	if (ImGui::BeginPopup(CreateComponentPopupID.c_str()))
	{
		std::vector<Class*> ComponentClasses;
		ClassContext::Get().GetClassOf(Component::StaticClass(), &ComponentClasses);

		for (auto& componentClass : ComponentClasses)
		{
			if(componentClass->HasFlag(ClassFlag::Abstruct))
			{
				continue;
			}
			auto itemName = "Create " + std::string(componentClass->Name());
			if (ImGui::Selectable(itemName.c_str()))
			{
				RE_LOG_INFO("Editor", "Create Component {0}", componentClass->Name());
			}
		}
		
		ImGui::EndPopup();
	}
}


