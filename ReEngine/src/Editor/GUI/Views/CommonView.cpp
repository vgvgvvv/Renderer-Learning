#include "CommonView.h"
#include "imgui.h"
#include "imgui_stdlib.h"

DEFINE_DRIVEN_CLASS_IMP_BEGIN(CommonView, IView, ClassFlag::Abstruct)
DEFINE_DRIVEN_CLASS_IMP_END();

DEFINE_VIEW_IMP(CommonView, Common)

static std::string InputTextID = "Common InputText";

std::string CommonView::InputTextTitle;
std::function<void(const std::string&)> CommonView::InputTextCallback;
bool CommonView::IsInputTextOpened = false;


void CommonView::InitSingleton()
{
}

void CommonView::OnInit()
{
}

void CommonView::OnGUI(float deltaTime)
{
	DrawInputText();
}

void CommonView::ShutDown()
{
}


void CommonView::DrawInputText()
{
	std::string InputTextFinalID = (InputTextID + InputTextTitle);
	if (IsInputTextOpened)
	{
		ImGui::SetNextItemWidth(500);
		ImGui::OpenPopup(InputTextFinalID.c_str());
	}
	if (ImGui::BeginPopupModal(InputTextFinalID.c_str()))
	{
		static std::string inputText;
		ImGui::InputText(InputTextTitle.c_str(), &inputText);
		if (ImGui::Button("OK"))
		{
			InputTextCallback(inputText);
			IsInputTextOpened = false;
			ImGui::CloseCurrentPopup();
		}
		ImGui::EndPopup();
	}
}

void CommonView::InputText(const std::string& title, std::function<void(const std::string&)> callback)
{
	InputTextTitle = title;
	InputTextCallback = callback;
	IsInputTextOpened = true;
}
