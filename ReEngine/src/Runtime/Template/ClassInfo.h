#pragma once
#include <string>
#include "Class.h"

#define DEFINE_CLASS(className) \
public:\
	typedef void Super; \
	static std::string StaticClassName() { return #className;}\
	static Class& StaticClass() { return selfClass; }\
	virtual std::string ClassName() { return #className; }\
private:\
	static Class selfClass;

#define DEFINE_CLASS_IMP(className) \
	Class className::selfClass(sizeof(className), nullptr, #className);

#define DEFINE_DRIVEN_CLASS(className, baseClassName) \
public:\
	typedef baseClassName Super; \
	static std::string StaticClassName() { return #className;}\
	static Class& StaticClass() { return selfClass; }\
	virtual std::string ClassName() override { return #className; }\
private:\
	static Class selfClass;

#define DEFINE_DRIVEN_CLASS_IMP(className, baseClassName) \
	Class className::selfClass(sizeof(className), &baseClassName::StaticClass(), #className);

#define DEFINE_TRANSFER(className) \
public:\
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc);\
	virtual void TransferJsonWrite(class JsonWrite& transfer);\
	virtual void TransferJsonRead(class JsonRead& transfer);\
	virtual void TransferImGui(class ImGuiTransfer& transfer);


// 定义存取函数
#define DEFINE_GETTER(typeName, varName) \
	const typeName& get_##varName() const { return varName; }

#define DEFINE_SETTER(typeName, varName) \
	void set_##varName(const typeName& varName) { this->varName = varName; }

#define DEFINE_GETTER_SETTER(typeName, varName) \
	DEFINE_GETTER(typeName, varName) \
	DEFINE_SETTER(typeName, varName)