#pragma once
#include <vector>

#include "IView.h"
#include "EditorGUI_API.h"
#include "DefineView.h"
#include "imgui.h"

enum class LogLevel
{
	Info,
	Debug,
	Warn,
	Error
};

static ImColor InfoColor = ImColor(0.5f, 0.5f, 0.5f, 1.0f);
static ImColor DebugColor = ImColor(1.0f, 1.0f, 1.0f, 1.0f);
static ImColor WarnColor = ImColor(1.0f, 0.92f, 0.0f, 1.0f);
static ImColor ErrorColor = ImColor(1.0f, 0.0f, 0.0f, 1.0f);

struct LogInfo
{
	LogLevel level;
	std::string message;
};

class EditorGUI_API LogView : public IView
{
	DEFINE_DRIVEN_CLASS(LogView, IView)
	DEFINE_VIEW(LogView, Log)
public:
	
private:
	std::vector<LogInfo> messages;
};
