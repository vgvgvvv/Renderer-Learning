#include "EditorContext.h"


void EditorContext::InitSingleton()
{
}

void EditorContext::SelectObject(GameObject* go)
{
	ClearSelectedAssets();
	auto& selectedObjects = SelectedGameObjects;
	selectedObjects.remove_if([go](GameObject* obj)
		{
			return obj != go;
		});
	AddSelectObject(go);
}

void EditorContext::AddSelectObject(GameObject* go)
{
	ClearSelectedAssets();
	auto& selectedObjects = SelectedGameObjects;

	if (std::find(selectedObjects.begin(),
		selectedObjects.end(),
		go) != selectedObjects.end())
	{
		SelectedGameObjects.remove(go);
	}
	else
	{
		SelectedGameObjects.push_back(go);
	}
}


bool EditorContext::IsSelectedObject(GameObject* go) const
{
	auto& selectedObjects = SelectedGameObjects;
	bool selected = std::find(selectedObjects.begin(), selectedObjects.end(), go) != selectedObjects.end();
	return selected;
}


void EditorContext::ClearSelectedObject()
{
	SelectedGameObjects.clear();
}


void EditorContext::SelectAsset(const std::string& path)
{
	ClearSelectedObject();
	auto& selectedAssets = SelectedAssetList;
	selectedAssets.remove_if([path](const std::string& obj)
		{
			return obj != path;
		});
	AddSelectAsset(path);
}

void EditorContext::AddSelectAsset(const std::string& path)
{
	ClearSelectedObject();
	auto& selectedAssets = SelectedAssetList;

	if (std::find(selectedAssets.begin(),
		selectedAssets.end(),
		path) != selectedAssets.end())
	{
		selectedAssets.remove(path);
	}
	else
	{
		selectedAssets.push_back(path);
	}
}

bool EditorContext::IsSelectedAsset(const std::string& path) const
{
	auto& selectedAssets = SelectedAssetList;
	bool selected = std::find(selectedAssets.begin(), selectedAssets.end(), path) != selectedAssets.end();
	return selected;
}

void EditorContext::ClearSelectedAssets()
{
	SelectedAssetList.clear();
}