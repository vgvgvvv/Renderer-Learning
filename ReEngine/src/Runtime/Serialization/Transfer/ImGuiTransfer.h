#pragma once

#include <map>
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

	template<class T>
	void transfer(std::list<std::shared_ptr<T>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		for (std::shared_ptr<T>& item : *data)
		{
			ImGuiTransfer write;
			item->TransferImGui(write);
		}
	}

	template<class T>
	void transfer(std::vector<std::shared_ptr<T>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		for (std::shared_ptr<T>& item : *data)
		{
			ImGuiTransfer write;
			item->TransferImGui(write);
		}
	}

	template<class TV>
	void transfer(std::map<std::string, std::shared_ptr<TV>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		for (std::shared_ptr<TV>& item : *data)
		{
			ImGuiTransfer write;
			write.transfer(item.first);
			item.second->TransferImGui(write);
		}
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

	template <class T>
	void transfer(ImGuiTransfer* transfer, std::shared_ptr<T>* data, const char* name, TransferFlag flag)
	{
		RE_ASSERT_MSG("Serilization", "Cannot Find Serilization For {0}", T::StaticName().c_str());
	}
}

#include "ImGuiTransfer/MathTransfer.h"