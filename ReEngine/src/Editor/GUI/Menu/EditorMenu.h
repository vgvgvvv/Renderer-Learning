#pragma once

#include "imgui.h"
#include "IView.h"
#include "Singleton.h"

class EditorMenu 
{
	DEFINE_SINGLETON(EditorMenu);
public:

	void OnInit();

	void OnGUI();

	void ShutDown();

public:

	
};
