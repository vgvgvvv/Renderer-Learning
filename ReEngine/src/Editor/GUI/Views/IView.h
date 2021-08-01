#pragma once
#include "ClassInfo.h"
#include "Menu/EditorMenu.h"
#include "EditorGUI_API.h"

class EditorGUI_API IView
{
	DEFINE_CLASS(IView)
public:
	bool isShow = true;
	virtual ~IView() = default;
	virtual const std::string& GetTitle() const = 0;
	virtual void OnInit()
	{
		EditorMenu::Get().AddMenuItem("Window/Open " + GetTitle(), [this]()
			{
				isShow = true;
			});
	}
	virtual void OnGUI(float deltaTime){}
	virtual void ShutDown(){}
};

