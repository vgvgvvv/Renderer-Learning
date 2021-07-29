#pragma once

#include "ClassInfo.h"
#include "Transfer/JsonTransfer.h"
#include "Transfer/ImGuiTransfer.h"


// 定义Component必要成员
#define DEFINE_COMPONENT(className)\
	template<class TransferFunction>\
	void TransferComponent(TransferFunction& transferFunc);\
	\
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc) { TransferComponent(transferFunc); }\
	virtual void TransferJsonWrite(const JsonWrite& transfer) { TransferComponent(transfer); }\
	virtual void TransferJsonRead(const JsonRead& transfer) { TransferComponent(transfer); }\
	virtual void TransferImGui(const ImGuiTransfer& transfer) { TransferComponent(transfer); }

	
