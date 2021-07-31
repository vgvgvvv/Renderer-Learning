#include "EditorMenu.h"



void EditorMenu::OnInit()
{
}

void EditorMenu::OnGUI()
{
	BuildMenuTree();
	if (ImGui::BeginMenuBar())
	{
		
	}
	ImGui::EndMenuBar();
}

void EditorMenu::ShutDown()
{
}

void EditorMenu::AddMenuItem(const std::string& name, std::function<void()> func)
{
}

void EditorMenu::BuildMenuTree()
{
	Root = std::shared_ptr<MenuTree>();
}
