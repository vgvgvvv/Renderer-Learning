#pragma once
#include "IView.h"
#include "EditorGUI_API.h"
#include "DefineView.h"

class EditorGUI_API LogView : public IView
{
	DEFINE_VIEW(LogView, Log)
};
