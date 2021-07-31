#pragma once
#include <vector>

#include "IView.h"
#include "EditorGUI_API.h"
#include "DefineView.h"
#include "imgui.h"
#include "Logging/Log.h"

class LogView;

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

class LogViewHandler : public ILogHandler
{
public:

	LogViewHandler(LogView* parent) : parent(parent) {};
	
	void Info(const std::string& logInfo) override;
	void Debug(const std::string& logInfo) override;
	void Warn(const std::string& logInfo) override;
	void Error(const std::string& logInfo) override;

private:
	LogView* parent;
};

class EditorGUI_API LogView : public IView
{
	DEFINE_DRIVEN_CLASS(LogView, IView)
	DEFINE_VIEW(LogView, Log)

	friend LogViewHandler;
public:

	LogView()
	{
		LogContext::RegisterHandler(std::make_shared<LogViewHandler>(this));
	}
private:
	void Clear();
	
private:
	std::vector<LogInfo> messages;
};
