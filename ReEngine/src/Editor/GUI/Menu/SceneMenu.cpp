#include "EditorMenu.h"

static StaticMenuItemDefine NewScene("File/New Scene", []()
	{
		RE_LOG_INFO("Editor", "New Scene");
	});

static StaticMenuItemDefine SaveScene("File/Save Scene", []()
	{
		RE_LOG_INFO("Editor", "Save Scene");
	});

static StaticMenuItemDefine OpenScene("File/Open Scene", []()
	{
		RE_LOG_INFO("Editor", "Open Scene");
	});