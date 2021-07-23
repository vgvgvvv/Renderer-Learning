#include "WorldOutlineView.h"

#include "Application.h"
#include "Layers/WorldLayer.h"
#include "imgui.h"
#include "Logging/Log.h"


static std::list<GameObject*> selectedObjects;

WorldOutlineView::WorldOutlineView()
{
}

void WorldOutlineView::OnInit()
{
}

static int index = 0;
void WorldOutlineView::OnGUI()
{
	auto& allGameObjects = World::Get().GetAllGameObjects();
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
}

static ImGuiTreeNodeFlags base_flags = ImGuiTreeNodeFlags_OpenOnArrow |	
	ImGuiTreeNodeFlags_OpenOnDoubleClick | 
	ImGuiTreeNodeFlags_SpanAvailWidth | 
	ImGuiTreeNodeFlags_DefaultOpen;


void WorldOutlineView::DrawGameObjectNode(GameObject* gameObject)
{
	if(gameObject->flag == GameObjectFlag::HideAndNotSave)
	{
		// 隐藏对象不绘制
		return;
	}
	
	ImGuiTreeNodeFlags node_flags = base_flags;

	if (std::find(selectedObjects.begin(), 
		selectedObjects.end(), 
		gameObject) != selectedObjects.end())
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
			selectedObjects.remove_if([gameObject](GameObject* obj)
				{
					return obj != gameObject;
				});
		}
		
		if (std::find(selectedObjects.begin(),
			selectedObjects.end(),
			gameObject) != selectedObjects.end())
		{
			selectedObjects.remove(gameObject);
		}
		else
		{
			selectedObjects.push_back(gameObject);
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
