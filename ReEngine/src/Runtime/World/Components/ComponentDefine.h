#pragma once


#define DEFINE_COMPONENT(className)\
	template<class TransferFunction>\
	void TransferComponent(TransferFunction& transferFunc);