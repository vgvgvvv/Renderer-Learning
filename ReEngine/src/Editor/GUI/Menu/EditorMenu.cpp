#include "EditorMenu.h"
#include "imgui.h"
#include "Misc/StringEx.h"
#include <map>
#include <list>
#include "Common.h"

class MenuNode
{
public:
	MenuNode(const std::string& name) : nodeName(name) {}

	virtual ~MenuNode() = default;
	virtual bool IsLeaf() const { return true; }

	std::string nodeName;
};

class MenuLeaf : public MenuNode
{
	friend EditorMenu;
public:
	bool IsLeaf() const override { return true; }

	MenuLeaf(const std::string& name, const MenuFunc& func) : MenuNode(name), func(func) {}

	MenuFunc func;
};

class MenuTree : public MenuNode
{
	typedef std::map<std::string, std::shared_ptr<MenuNode>> NodeMap;
	
	friend EditorMenu;
public:
	bool IsLeaf() const override { return false; }

	MenuTree(const std::string& name) : MenuNode(name)
	{
	}

	std::shared_ptr<MenuNode>& GetOrAddTree(const std::string& name)
	{
		if (subNodes.contains(name))
		{
			return subNodes.at(name);
		}
		auto node = std::make_shared<MenuTree>(name);
		subNodes.insert(std::make_pair(name, node));
		return subNodes[name];
	}

	void AddFunc(const std::string& name, const MenuFunc& func)
	{
		if (subNodes.contains(name))
		{
			return;
		}
		auto node = std::make_shared<MenuLeaf>(name, func);
		subNodes.insert(std::make_pair(name, node));
	}


private:
	NodeMap subNodes;
};



void EditorMenu::OnInit()
{
	Root = std::make_shared<MenuTree>("Root");
}

void EditorMenu::OnGUI()
{
	if (ImGui::BeginMenuBar())
	{
		for (auto& sub_node : Root->subNodes)
		{
			auto& itemName = sub_node.first;
			auto& node = sub_node.second;
			if (!node->IsLeaf())
			{
				if(ImGui::BeginMenu(itemName.c_str(), true))
				{
					DrawMenuItem(std::static_pointer_cast<MenuTree>(node));
					ImGui::EndMenu();
				}
			}
			else
			{
				RE_LOG_WARN("Editor", "Invalid Menu {0}", itemName.c_str())
			}
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
	std::shared_ptr<MenuTree> currentNode = Root;
	for(int i = 0; i < items.size()-1; i ++)
	{
		std::string& item = items[i];
		currentNode = std::static_pointer_cast<MenuTree>(currentNode->GetOrAddTree(item));
	}
	auto& funcName = items[items.size() - 1];
	currentNode->AddFunc(funcName, func);
}

void EditorMenu::DrawMenuItem(const std::shared_ptr<MenuTree>& tree)
{
	auto& nodes = tree->subNodes;
	for (auto& pair : nodes)
	{
		auto& itemName = pair.first;
		auto& node = pair.second;
		if(!node->IsLeaf())
		{
			if (ImGui::BeginMenu(itemName.c_str(), true))
			{
				DrawMenuItem(std::static_pointer_cast<MenuTree>(node));
			}
			ImGui::EndMenu();
		}else
		{
			if (ImGui::MenuItem(itemName.c_str(), "", false, true))
			{
				auto leaf = std::static_pointer_cast<MenuLeaf>(node);
				if(leaf->func)
				{
					leaf->func();
				}
			}
		}
	}
}

