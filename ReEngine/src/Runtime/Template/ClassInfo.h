#pragma once
#include <string>

#define DEFINE_CLASS(className) \
public:\
	typedef void Super; \
	static std::string StaticClassName() { return #className;}\
	virtual std::string ClassName() { return #className; }

#define DEFINE_DRIVEN_CLASS(className, baseClassName) \
public:\
	typedef baseClassName Super; \
	static std::string StaticClassName() { return #className;}\
	virtual std::string ClassName() override { return #className; } 

#define DEFINE_TRANSFER(className) \
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc);\
	virtual void TransferJsonWrite(const class JsonWrite& transfer);\
	virtual void TransferJsonRead(const class JsonRead& transfer);\
	virtual void TransferImGui(const class ImGuiTransfer& transfer);