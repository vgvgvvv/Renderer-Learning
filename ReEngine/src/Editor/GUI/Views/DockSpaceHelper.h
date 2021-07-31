#pragma once
#include "imgui.h"

class DockSpaceHelper
{
public:

	static void BeginDockerSapce();

	static void EndDockSpace();

private:
	static ImGuiDockNodeFlags dockSpaceFlags;
};