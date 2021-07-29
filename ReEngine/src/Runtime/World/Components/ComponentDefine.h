#pragma once

#include "ClassInfo.h"
#include "Transfer/JsonTransfer.h"
#include "Transfer/ImGuiTransfer.h"


// ����Component��Ҫ��Ա
#define DEFINE_COMPONENT(className)\
	template<class TransferFunction>\
	void TransferComponent(TransferFunction& transferFunc);\
	\
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc) { TransferComponent(transferFunc); }\
	virtual void TransferJsonWrite(JsonWrite& transfer) { TransferComponent(transfer); }\
	virtual void TransferJsonRead(JsonRead& transfer) { TransferComponent(transfer); }\
	virtual void TransferImGui(ImGuiTransfer& transfer) { TransferComponent(transfer); }

	
