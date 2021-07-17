#include "WorldOutlineView.h"

#include "Application.h"
#include "Layers/WorldLayer.h"
#include "imgui.h"


void WorldOutlineView::OnInit()
{
}

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

static ImGuiTreeNodeFlags base_flags = ImGuiTreeNodeFlags_OpenOnArrow | ImGuiTreeNodeFlags_OpenOnDoubleClick | ImGuiTreeNodeFlags_SpanAvailWidth;

void WorldOutlineView::DrawGameObjectNode(GameObject* gameObject)
{
	if(gameObject->GetChildren().size() == 0)
	{
		//Leaf
		ImGuiTreeNodeFlags node_flags = base_flags | 
			ImGuiTreeNodeFlags_Leaf | 
			ImGuiTreeNodeFlags_NoTreePushOnOpen;
		ImGui::TreeNodeEx(gameObject->GetName().c_str(), node_flags);
	}else
	{
		//Tree
		ImGuiTreeNodeFlags node_flags = base_flags;
		bool open_node = ImGui::TreeNodeEx(gameObject->GetName().c_str(), node_flags);

		if(open_node)
		{
			auto& children = gameObject->GetChildren();

			for (auto child : children)
			{
				DrawGameObjectNode(child);
			}
			
			ImGui::TreePop();
		}
	}
}
