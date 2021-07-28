#pragma once
#include <fstream>
#include <string>


#include "uuid.h"
#include "GlobalAssets_API.h"
#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"
#include "nlohmann/json.hpp"

using namespace nlohmann;

class GlobalAssets_API JsonRead : public IBaseTransfer
{
public:

	JsonRead(const std::string& filePath);


	bool IsLoading() override { return true; }
	bool IsWriting() override { return false; }

	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		*data = doc[name].get<T>();
	}

	template<class T>
	void transfer(std::list<T>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		data->clear();
		auto arr = doc[name];
		if(arr.is_array())
		{
			auto size = arr.size();
			for(int i = 0; i < size; i ++)
			{
				data->push_back(arr[i].get<T>());
			}
		};
	}

	template<class T>
	void transfer(std::vector<T>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		data->clear();
		auto arr = doc[name];
		if (arr.is_array())
		{
			auto size = arr.size();
			for (int i = 0; i < size; i++)
			{
				data->push_back(arr[i].get<T>());
			}
		};
	}

	template<class TV>
	void transfer(std::map<std::string, TV>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		data->clear();
		auto obj = doc[name];
		if (obj.is_object())
		{
			for(auto& el : obj.items())
			{
				data->insert(std::pair<std::string, TV>(el.key(), el.value().get<TV>()));
			}
		};
	}
	
	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);
	
private:
	std::string filePath;
	nlohmann::json doc;
};

class GlobalAssets_API JsonWrite : public IBaseTransfer
{
public:

	JsonWrite(const std::string& filePath);

	bool IsLoading() override { return false; }
	bool IsWriting() override { return true; }

	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		doc[name] = *data;
	}

	template<class T>
	void transfer(std::list<T>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		auto arr = json::array();

		for (T& item : data)
		{
			arr.push_back(item);
		}
		doc[name] = arr;
	}

	template<class T>
	void transfer(std::vector<T>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		auto arr = json::array();

		for (T& item : data)
		{
			arr.push_back(item);
		}
		doc[name] = arr;
	}

	template<class TK, class TV>
	void transfer(std::map<TK, TV>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		auto obj = json::object();

		for (std::pair<TK, TV>& item : data)
		{
			obj[item.first] = item.second;
		}
		doc[name] = obj;
	}

	
	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);

	void Save();
	
private:
	std::string filePath;
	nlohmann::json doc;
};
