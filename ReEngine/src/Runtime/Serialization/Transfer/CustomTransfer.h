#pragma once

#define DEFINE_TYPE_TRANSFER(transferType, targetType) \
	template<>\
	void transfer(transferType* read, targetType* data, const char* name, TransferFlag flag);\

