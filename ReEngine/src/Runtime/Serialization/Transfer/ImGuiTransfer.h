#pragma once

#include <string>

#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"
#include "Serialization_API.h"

class Vector3;

class Serialization_API ImGuiTransfer : public IBaseTransfer
{
public:

	bool IsImGui() const override { return true; }

	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(Vector3* data, const char* name, TransferFlag flag = TransferFlag::None);
};
