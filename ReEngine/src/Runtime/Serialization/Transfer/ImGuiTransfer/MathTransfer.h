#pragma once
#include "Vector3.h"
#include "Quaternion.h"
#include "Transfer/CustomTransfer.h"
#include "imgui.h"

namespace TransferDetail
{
	template <>
	inline void transfer(ImGuiTransfer* transfer, Vector3* data, const char* name, TransferFlag flag)
	{
		ImGui::InputFloat3(name, (float*)data, "%.1f");
	}

	template <>
	inline void transfer(ImGuiTransfer* transfer, Quaternion* data, const char* name, TransferFlag flag)
	{
		ImGui::InputFloat4(name, (float*)data, "%.1f");
	}
}
