#pragma once
#include "IView.h"
#include "DefineView.h"

class CommonView : IView
{
	DEFINE_DRIVEN_CLASS(GameView, IView)
	DEFINE_VIEW(CommonView, Common)

	DEFINE_SINGLETON(CommonView)
	
private:
	static std::string InputTextTitle;
	static std::function<void(const std::string&)> InputTextCallback;
	static bool IsInputTextOpened;

	void DrawInputText();
public:
	static void InputText(const std::string& title, std::function<void(const std::string&)> callback);
};
