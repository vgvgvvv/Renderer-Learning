#pragma once

#include <string>

#include "ImGUILib_API.h"
#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"

class Vector3;

class ImGUILib_API ImGuiTransfer : public IBaseTransfer
{
public:

	bool IsImGui() const override { return true; }

	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(Vector3* data, const char* name, TransferFlag flag = TransferFlag::None);
};
