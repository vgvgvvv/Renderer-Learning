#pragma once

#include <string>


#include "CommonAssert.h"
#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"
#include "Serialization_API.h"

class ImGuiTransfer;

namespace TransferDetail
{
	template<class T>
	void transfer(ImGuiTransfer* transfer, T* data, const char* name, TransferFlag flag = TransferFlag::None);
}

class Serialization_API ImGuiTransfer : public IBaseTransfer
{
public:

	bool IsImGui() const override { return true; }

	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		TransferDetail::transfer<T>(this, data, name, flag);
	}
	
	void transfer(bool* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(int* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(float* data, const char* name, TransferFlag flag = TransferFlag::None);
	void transfer(std::string* data, const char* name, TransferFlag flag = TransferFlag::None);
};

namespace TransferDetail
{
	template <class T>
	void transfer(ImGuiTransfer* transfer, T* data, const char* name, TransferFlag flag)
	{
		RE_ASSERT_MSG("Serilization", "Cannot Find Serilization For {0}", T::StaticName().c_str());
	}
}

#include "ImGuiTransfer/MathTransfer.h"