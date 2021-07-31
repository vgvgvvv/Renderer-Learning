#pragma once

#include <functional>
#include <list>
#include <map>

#include "imgui.h"
#include "Singleton.h"

class MenuNode
{
public:
	virtual ~MenuNode() = default;
	virtual bool IsLeaf() const { return true; }

	std::string nodeName;
};

class MenuTree : public MenuNode
{
public:
	bool IsLeaf() const override { return false; }

	std::vector<std::string, std::shared_ptr<MenuNode>> subNodes;
};

class MenuLeaf : public MenuNode
{
public:
	bool IsLeaf() const override { return true; }

	std::function<void()> func;
};

class EditorMenu 
{
	DEFINE_SINGLETON(EditorMenu);
public:

	void OnInit();

	void OnGUI();

	void ShutDown();

	void AddMenuItem(const std::string& name, std::function<void()> func);

private:

	void BuildMenuTree();
	std::map<std::string, std::function<void()>> menuFuncs;

	std::shared_ptr<MenuTree> Root;
};
