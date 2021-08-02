#pragma once
#include <fstream>
#include <string>


#include "uuid.h"
#include "Transfer/BaseTransfer.h"
#include "Transfer/TransferFlag.h"
#include "nlohmann/json.hpp"
#include <filesystem>
#include "Serialization_API.h"

class JsonRead;
class JsonWrite;

using namespace nlohmann;
namespace fs = std::filesystem;

namespace TransferDetail
{
	template<class T>
	void transfer(JsonRead* read, T* data, const char* name, TransferFlag flag = TransferFlag::None);

	template<class T>
	void transfer(JsonWrite* writer, T* data, const char* name, TransferFlag flag = TransferFlag::None);
}

class Serialization_API JsonRead : public IBaseTransfer
{
public:
	
	template<class T>
	friend void TransferDetail::transfer(JsonRead* read, T* data, const char* name, TransferFlag flag);

	JsonRead(json doc) : doc(doc){};
	JsonRead(const std::string& filePath);


	bool IsLoading() const override { return true; }
	bool IsWriting() const override { return false; }
	bool IsValid() const { return fs::exists(filePath); }
	
	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		TransferDetail::transfer<T>(this, data, name, flag);
	}

	template<class T>
	void transfer(std::list<std::shared_ptr<T>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		data->clear();
		auto arr = doc[name];
		if(arr.is_array())
		{
			auto size = arr.size();
			for(int i = 0; i < size; i ++)
			{
				std::shared_ptr<T> item = std::static_pointer_cast<T>(T::StaticClass()->Create());
				JsonRead read(arr[i]);
				item->TransferJsonRead(read);
				data->push_back(item);
			}
		};
	}

	template<class T>
	void transfer(std::vector<std::shared_ptr<T>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		data->clear();
		auto arr = doc[name];
		if (arr.is_array())
		{
			auto size = arr.size();
			for (int i = 0; i < size; i++)
			{
				std::shared_ptr<T> item = std::static_pointer_cast<T>(T::StaticClass()->Create());
				JsonRead read(arr[i]);
				item->TransferJsonRead(read);
				data->push_back(item);
			}
		};
	}

	template<class TV>
	void transfer(std::map<std::string, std::shared_ptr<TV>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		data->clear();
		auto obj = doc[name];
		if (obj.is_object())
		{
			for(auto& el : obj.items())
			{
				std::shared_ptr<TV> item = std::static_pointer_cast<TV>(TV::StaticClass()->Create());
				JsonRead read(el.value());
				item->TransferJsonRead(read);
				data->insert(std::pair<std::string, TV>(el.key(), item));
			}
		};
	}
	
	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);
	
private:
	std::string filePath;
	nlohmann::json doc;
};



class Serialization_API JsonWrite : public IBaseTransfer
{
public:

	template<class T>
	friend void TransferDetail::transfer(JsonWrite* writer, T* data, const char* name, TransferFlag flag);

	JsonWrite();
	JsonWrite(const std::string& filePath);

	bool IsLoading() const override { return false; }
	bool IsWriting() const override { return true; }
	bool IsValid() const { return fs::exists(filePath); }
	
	template<class T>
	void transfer(T* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		TransferDetail::transfer(this, data, name, flag);
	}

	template<class T>
	void transfer(std::list<std::shared_ptr<T>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		auto arr = json::array();

		for (std::shared_ptr<T>& item : *data)
		{
			JsonWrite write;
			item->TransferJsonWrite(write);
			arr.push_back(write.doc);
		}
		doc[name] = arr;
	}

	template<class T>
	void transfer(std::vector<std::shared_ptr<T>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		auto arr = json::array();

		for (std::shared_ptr<T>& item : *data)
		{
			JsonWrite write;
			item->TransferJsonWrite(write);
			arr.push_back(write.doc);
		}
		doc[name] = arr;
	}

	template<class TV>
	void transfer(std::map<std::string, std::shared_ptr<TV>>* data, const char* name, TransferFlag flag = TransferFlag::None)
	{
		auto obj = json::object();

		for (std::pair<std::string, std::shared_ptr<TV>>& item : *data)
		{
			JsonWrite write;
			item.second->TransferJsonWrite(write);
			obj[item.first] = write.doc;
		}
		doc[name] = obj;
	}

	
	void transfer(uuids::uuid* data, const char* name, TransferFlag flag = TransferFlag::None);

	void Save();
	
private:
	std::string filePath;
	nlohmann::json doc;
};

namespace TransferDetail
{
	template<class T>
	void transfer(JsonRead* read, T* data, const char* name, TransferFlag flag)
	{
		*data = read->doc[name].get<T>();
	}


	template <class T>
	void transfer(JsonWrite* writer, T* data, const char* name, TransferFlag flag)
	{
		writer->doc[name] = *data;
	}
}

#include "JsonTransfer/MathTransfer.h"
