#pragma once
#include "IView.h"
#include "EditorGUI_API.h"
#include "DefineView.h"

class EditorGUI_API GameView : public IView
{
	DEFINE_DRIVEN_CLASS(GameView, IView)
	DEFINE_VIEW(GameView, Game)

};
