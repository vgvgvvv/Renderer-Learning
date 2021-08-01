#include "LogView.h"

DEFINE_DRIVEN_CLASS_IMP(LogView, IView)
DEFINE_VIEW_IMP(LogView, Log)


void LogViewHandler::Info(const std::string& logInfo)
{
	LogInfo info;
	info.level = LogLevel::Info;
	info.message = logInfo;
	parent->messages.push_back(info);
}

void LogViewHandler::Debug(const std::string& logInfo)
{
	LogInfo info;
	info.level = LogLevel::Debug;
	info.message = logInfo;
	parent->messages.push_back(info);
}

void LogViewHandler::Warn(const std::string& logInfo)
{
	LogInfo info;
	info.level = LogLevel::Warn;
	info.message = logInfo;
	parent->messages.push_back(info);
}

void LogViewHandler::Error(const std::string& logInfo)
{
	LogInfo info;
	info.level = LogLevel::Error;
	info.message = logInfo;
	parent->messages.push_back(info);
}

void LogView::OnInit()
{
	Super::OnInit();
}

void LogView::OnGUI(float deltaTime)
{
	Super::OnGUI(deltaTime);
	if(ImGui::Button("Clear", ImVec2(50, 20)))
	{
		Clear();
	}
	for (auto& message : messages)
	{
		switch (message.level)
		{
		case LogLevel::Info:
			ImGui::TextColored(InfoColor, message.message.c_str());
			break;
		case LogLevel::Debug:
			ImGui::TextColored(DebugColor, message.message.c_str());
			break;
		case LogLevel::Warn:
			ImGui::TextColored(WarnColor, message.message.c_str());
			break;
		case LogLevel::Error:
			ImGui::TextColored(ErrorColor, message.message.c_str());
			break;
		}
	}
}

void LogView::ShutDown()
{
	Super::ShutDown();
}

void LogView::Clear()
{
	messages.clear();
}
