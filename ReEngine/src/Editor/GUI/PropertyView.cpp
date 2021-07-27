#include "PropertyView.h"

#include "EditorContext.h"
#include "imgui.h"


void PropertyView::OnInit()
{
}

void PropertyView::OnGUI()
{
	DrawSelectedGameObject();
}

void PropertyView::ShutDown()
{
}

void PropertyView::DrawSelectedGameObject()
{
	auto& selectedObject = EditorContext::Get().SelectedGameObjects;
	if(selectedObject.size() != 1)
	{
		return;
	}

	const auto showObject = *selectedObject.begin();
	
	ImGui::Text(showObject->GetName().c_str());

	for (auto component : showObject->GetComponents())
	{
		
	}
}
