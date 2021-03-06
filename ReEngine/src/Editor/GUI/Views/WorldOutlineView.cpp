#include "WorldOutlineView.h"

#include "Application.h"
#include "EditorContext.h"
#include "Layers/WorldLayer.h"
#include "imgui.h"
#include "Logging/Log.h"


DEFINE_DRIVEN_CLASS_IMP(WorldOutlineView, IView)
DEFINE_VIEW_IMP(WorldOutlineView, WorldOutline)

void WorldOutlineView::OnInit()
{
	Super::OnInit();
}

static int index = 0;
void WorldOutlineView::OnGUI(float deltaTime)
{
	Super::OnGUI(deltaTime);
	auto& allGameObjects = World::Get().GetAllGameObjects();

	DrawPanelRightClickMenu();
	
	for (auto gameObject : allGameObjects)
	{
		if(gameObject->GetParent() == nullptr)
		{
			DrawGameObjectNode(gameObject);
		}
	}
	
}


void WorldOutlineView::ShutDown()
{
	Super::ShutDown();
}

static ImGuiTreeNodeFlags base_flags = ImGuiTreeNodeFlags_OpenOnArrow |	
	ImGuiTreeNodeFlags_OpenOnDoubleClick | 
	ImGuiTreeNodeFlags_SpanAvailWidth | 
	ImGuiTreeNodeFlags_DefaultOpen;


void WorldOutlineView::DrawGameObjectNode(GameObject* gameObject)
{
	if(gameObject->flag == GameObjectFlag::HideAndNotSave)
	{
		// ???ض??󲻻???
		return;
	}
	
	ImGuiTreeNodeFlags node_flags = base_flags;

	bool selected = EditorContext::Get().IsSelectedObject(gameObject);
	if (selected)
	{
		node_flags |= ImGuiTreeNodeFlags_Selected;
	}
	
	if(gameObject->GetChildren().size() == 0)
	{
		//Leaf
		node_flags |= ImGuiTreeNodeFlags_Leaf | 
			ImGuiTreeNodeFlags_NoTreePushOnOpen;
		
		ImGui::TreeNodeEx(gameObject->GetName().c_str(), node_flags);

		OnGameObjectNodeClick(gameObject, true);
		DrawGameObjectRightClickMenu(gameObject, true);

	}else
	{
		//Tree
		bool open_node = ImGui::TreeNodeEx(gameObject->GetName().c_str(), node_flags);

		OnGameObjectNodeClick(gameObject, false);
		DrawGameObjectRightClickMenu(gameObject, false);

		if(open_node)
		{
			auto& children = gameObject->GetChildren();

			for (auto child : children)
			{
				// ImGui::Indent(ImGui::GetTreeNodeToLabelSpacing());
				DrawGameObjectNode(child);
				// ImGui::Unindent(ImGui::GetTreeNodeToLabelSpacing());
			}
			
			ImGui::TreePop();
		}

	}
}

void WorldOutlineView::OnGameObjectNodeClick(GameObject* gameObject, bool isLeaf)
{
	
	if (ImGui::IsItemClicked())
	{
		if(!ImGui::GetIO().KeyCtrl)
		{
			EditorContext::Get().SelectObject(gameObject);
		}else
		{
			EditorContext::Get().AddSelectObject(gameObject);
		}
		
	}
}

void WorldOutlineView::DrawGameObjectRightClickMenu(GameObject* gameObject, bool isLeaf)
{
	std::string popupName("asset popup");

	popupName += *gameObject->GetGuid();
 	
	if (ImGui::BeginPopupContextItem(popupName.c_str()))
	{
		if (ImGui::Selectable("Create Object"))
		{
			auto newObject = World::Get().CreateGameObject();
			newObject->SetParent(gameObject);
		}
		if (ImGui::Selectable("Delete Object"))
		{
			World::Get().DestroyGameObject(gameObject);
		}
		ImGui::EndPopup();
	}
	ImGui::OpenPopupOnItemClick(popupName.c_str(), ImGuiPopupFlags_MouseButtonRight);
}

void WorldOutlineView::DrawPanelRightClickMenu()
{
	std::string popupName("worldoutline panel popup");

	if (ImGui::Button("Edit"))
	{
		ImGui::OpenPopup(popupName.c_str());
	}
	if (ImGui::BeginPopup(popupName.c_str()))
	{
		if (ImGui::Selectable("Create Object"))
		{
			World::Get().CreateGameObject();
		}
		ImGui::EndPopup();
	}
}
