#include "DockSpaceHelper.h"

ImGuiDockNodeFlags DockSpaceHelper::dockSpaceFlags = ImGuiDockNodeFlags_None;

void DockSpaceHelper::BeginDockerSapce()
{
	ImGuiWindowFlags windowFlags = 
		ImGuiWindowFlags_MenuBar | ImGuiWindowFlags_NoDocking;

	auto viewport = ImGui::GetMainViewport();
	ImGui::SetNextWindowPos(viewport->WorkPos, 0, ImVec2());
	ImGui::SetNextWindowSize(viewport->WorkSize, 0);
	ImGui::SetNextWindowViewport(viewport->ID);
	ImGui::PushStyleVar(ImGuiStyleVar_WindowRounding, 0.0f);
	ImGui::PushStyleVar(ImGuiStyleVar_WindowBorderSize, 0.0f);

	windowFlags |= ImGuiWindowFlags_NoTitleBar |
		ImGuiWindowFlags_NoCollapse |
		ImGuiWindowFlags_NoResize |
		ImGuiWindowFlags_NoMove |
		ImGuiWindowFlags_NoBringToFrontOnFocus |
		ImGuiWindowFlags_NoNavFocus;

	static bool open = true;
	ImGui::Begin("DockSpace", &open, windowFlags);

	ImGui::PopStyleVar(2);

	auto io = ImGui::GetIO();
	auto dockerSpaceId = ImGui::GetID("Main Dock Space");
	ImGui::DockSpace(dockerSpaceId, ImVec2(), dockSpaceFlags, nullptr);
		
}

void DockSpaceHelper::EndDockSpace()
{
	ImGui::End();
}
