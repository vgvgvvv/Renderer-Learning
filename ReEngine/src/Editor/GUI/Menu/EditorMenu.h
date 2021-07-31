#pragma once

#include <functional>
#include <memory>
#include <string>

#include "Singleton.h"


class MenuLeaf;
class MenuNode;
class MenuTree;

typedef std::function<void()> MenuFunc;



class EditorMenu 
{
	DEFINE_SINGLETON(EditorMenu)
public:

	void OnInit();

	void OnGUI();

	void ShutDown();

	void AddMenuItem(const std::string& name, MenuFunc func);

	void DrawMenuItem(const std::shared_ptr<MenuTree>& tree);

private:

	std::shared_ptr<MenuTree> Root;
};
