#pragma once

#include <functional>
#include <map>
#include <memory>
#include <vector>
#include <string>

#include "Singleton.h"


typedef std::function<void()> MenuFunc;

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

	std::map<std::string, MenuFunc> subNodes;
};

class MenuLeaf : public MenuNode
{
public:
	bool IsLeaf() const override { return true; }

	MenuFunc func;
};

class EditorMenu 
{
	DEFINE_SINGLETON(EditorMenu)
public:

	void OnInit();

	void OnGUI();

	void ShutDown();

	void AddMenuItem(const std::string& name, MenuFunc func);

private:

	void BuildMenuTree();

	std::shared_ptr<MenuTree> Root;
};
