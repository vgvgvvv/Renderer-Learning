#pragma once

#include "EditorGUI_API.h"

class EditorGUI_API AssetView
{
public:
	void OnInit();

	void OnGUI();

	void ShutDown();

private:
	bool lastIsFocused = false;

};