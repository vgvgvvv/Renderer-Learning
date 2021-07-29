#include "ImGuiTransfer.h"
#include "imgui.h"
#include "imgui_stdlib.h"

void ImGuiTransfer::transfer(bool* data, const char* name, TransferFlag flag)
{
	ImGui::Checkbox(name, data);
}

void ImGuiTransfer::transfer(int* data, const char* name, TransferFlag flag)
{
	ImGui::InputInt(name, data);
}

void ImGuiTransfer::transfer(float* data, const char* name, TransferFlag flag)
{
	ImGui::InputFloat(name, data);
}

void ImGuiTransfer::transfer(std::string* data, const char* name, TransferFlag flag)
{
	ImGui::InputText(name, data);
}
