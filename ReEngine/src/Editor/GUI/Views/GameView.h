#pragma once
#include "IView.h"
#include "EditorGUI_API.h"

class EditorGUI_API GameView : public IView
{
public:
	const std::string& GetTitle() const override;
	void OnInit() override;
	void OnGUI() override;
	void ShutDown() override;
};
