#pragma once

#include <list>
#include <string>


#include "EditorContext_API.h"
#include "Singleton.h"

class GameObject;

class EditorContext_API EditorContext
{
	DEFINE_SINGLETON(EditorContext);

private:
	std::list<GameObject*> SelectedGameObjects;
	std::list<std::string> SelectedAssetList;
	
public:

	std::list<GameObject*>& GetAllSelectGameObjects() { return SelectedGameObjects; }
	std::list<std::string>& GetAllSelectAssets() { return SelectedAssetList; }
	
	void SelectObject(GameObject* go);
	void AddSelectObject(GameObject* go);
	bool IsSelectedObject(GameObject* go) const;
	void ClearSelectedObject();

	void SelectAsset(const std::string& path);
	void AddSelectAsset(const std::string& path);
	bool IsSelectedAsset(const std::string& path) const;
	void ClearSelectedAssets();
	
	

};
