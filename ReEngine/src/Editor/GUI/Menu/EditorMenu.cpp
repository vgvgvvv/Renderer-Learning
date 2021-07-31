#include "EditorMenu.h"
#include "imgui.h"
#include "Misc/StringEx.h"


void EditorMenu::OnInit()
{
}

void EditorMenu::OnGUI()
{
	BuildMenuTree();
	if (ImGui::BeginMenuBar())
	{
		for (auto sub_node : Root->subNodes)
		{
			// TODO
		}
	}
	ImGui::EndMenuBar();
}

void EditorMenu::ShutDown()
{
}

void EditorMenu::AddMenuItem(const std::string& name, MenuFunc func)
{
	auto items = StringEx::Split(name, "/");
	// TODO
}

void EditorMenu::BuildMenuTree()
{
	Root = std::shared_ptr<MenuTree>();
}
