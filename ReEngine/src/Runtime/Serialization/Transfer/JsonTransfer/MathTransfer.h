#pragma once
#include "Quaternion.h"
#include "Transfer/CustomTransfer.h"
#include "Vector3.h"

namespace TransferDetail
{
	
	template <>
	inline void transfer(JsonRead* read, Vector3* data, const char* name, TransferFlag flag)
	{
		auto& obj = read->doc[name];
		data->x = obj["x"].get<float>();
		data->y = obj["y"].get<float>();
		data->z = obj["z"].get<float>();
	}

	template <>
	inline void transfer(JsonRead* read, Quaternion* data, const char* name, TransferFlag flag)
	{
		auto& obj = read->doc[name];
		data->x = obj["x"].get<float>();
		data->y = obj["y"].get<float>();
		data->z = obj["z"].get<float>();
		data->w = obj["w"].get<float>();
	}

}


namespace TransferDetail
{
	
	template <>
	inline void transfer(JsonWrite* write, Vector3* data, const char* name, TransferFlag flag)
	{
		auto obj = json::object();
		obj["x"] = data->x;
		obj["y"] = data->y;
		obj["z"] = data->z;
		write->doc[name] = obj;
	}

	template <>
	inline void transfer(JsonWrite* write, Quaternion* data, const char* name, TransferFlag flag)
	{
		auto obj = json::object();
		obj["x"] = data->x;
		obj["y"] = data->y;
		obj["z"] = data->z;
		obj["w"] = data->w;
		write->doc[name] = obj;
	}
	
}