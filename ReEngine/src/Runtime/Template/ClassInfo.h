#pragma once
#include <string>
#include "Class.h"
#include "MacroMisc.h"

//------------------------------------------------------------------------------
// 反射类相关初始化宏
#define SET_DEFAULT_CLASS_CTOR(className) \
	self->SetCtor([](){ return std::make_shared<className>(); });

#define SET_CLASS_CTOR(ctorFunc) \
	self->SetCtor(ctorFunc);


//------------------------------------------------------------------------------
// 反射类相关宏

#define DEFINE_CLASS_DYNAMIC(className) \
public:\
	typedef void Super; \
	static std::string StaticClassName() { return #className;}\
	static const Class* StaticClass() { return &GetSelfClass(); }\
	virtual const Class* GetClass() { return className::StaticClass(); }\
	virtual std::string ClassName() { return #className; }\
private:\
	static Class& GetSelfClass(){\
		static Class selfClass(sizeof(className), \
		nullptr, \
		#className, \
		ClassFlag::None, \
		[](Class* self){ \
		});\
		return selfClass;\
	}

#define DEFINE_CLASS(className) \
public:\
	typedef void Super; \
	static std::string StaticClassName() { return #className;}\
	static const Class* StaticClass() { return &selfClass; }\
	virtual const Class* GetClass() { return className::StaticClass(); }\
	virtual std::string ClassName() { return #className; }\
private:\
	static Class selfClass;

#define DEFINE_CLASS_IMP_BEGIN(className, flag) \
	Class className::selfClass(sizeof(className), \
		nullptr, \
		#className, \
		flag, \
		[](Class* self){

#define DEFINE_CLASS_IMP_END() \
	});

#define DEFINE_CLASS_IMP(className) \
	DEFINE_CLASS_IMP_BEGIN(className, ClassFlag::None)\
	SET_DEFAULT_CLASS_CTOR(className);\
	DEFINE_CLASS_IMP_END()


#define DEFINE_CLASS_IMP_WITH_FLAG(className, flag) \
	DEFINE_CLASS_IMP_BEGIN(className, flag)\
	SET_DEFAULT_CLASS_CTOR(className);\
	DEFINE_CLASS_IMP_END()



// 定义派生类

#define DEFINE_DRIVEN_CLASS_DYNAMIC(className, baseClassName) \
public:\
	typedef baseClassName Super; \
	static std::string StaticClassName() { return #className;}\
	static const Class* StaticClass() { return &GetSelfClass(); }\
	virtual const Class* GetClass() override { return className::StaticClass(); }\
	virtual std::string ClassName() override { return #className; }\
private:\
	static Class& GetSelfClass(){\
		static Class selfClass(sizeof(className), \
		baseClassName::GetSelfClass(), \
		#className, \
		flag, \
		[](Class* self){ \
		});\
		return selfClass;\
	}


#define DEFINE_DRIVEN_CLASS(className, baseClassName) \
public:\
	typedef baseClassName Super; \
	static std::string StaticClassName() { return #className;}\
	static const Class* StaticClass() { return &selfClass; }\
	virtual const Class* GetClass() override { return className::StaticClass(); }\
	virtual std::string ClassName() override { return #className; }\
private:\
	static Class selfClass;



#define DEFINE_DRIVEN_CLASS_IMP_BEGIN(className, baseClassName, flag) \
	Class className::selfClass(sizeof(className), \
		baseClassName::StaticClass(), \
		#className, \
		flag, \
		[](Class* self){ \
			

#define DEFINE_DRIVEN_CLASS_IMP_END() \
	});


#define DEFINE_DRIVEN_CLASS_IMP(className, baseClassName) \
	DEFINE_DRIVEN_CLASS_IMP_BEGIN(className, baseClassName, ClassFlag::None)\
	SET_DEFAULT_CLASS_CTOR(className);\
	DEFINE_DRIVEN_CLASS_IMP_END()


#define DEFINE_DRIVEN_CLASS_IMP_WITH_FLAG(className, baseClassName, flag) \
	DEFINE_DRIVEN_CLASS_IMP_BEGIN(className, baseClassName, flag)\
	SET_DEFAULT_CLASS_CTOR(className);\
	DEFINE_DRIVEN_CLASS_IMP_END()


//------------------------------------------------------------------------------
// 定义序列化
#define DEFINE_TRANSFER(className) \
public:\
	template<class TransferFunction>\
	void TransferClass(TransferFunction& transferFunc);\
	virtual void TransferJsonWrite(class JsonWrite& transfer);\
	virtual void TransferJsonRead(class JsonRead& transfer);\
	virtual void TransferImGui(class ImGuiTransfer& transfer);


//------------------------------------------------------------------------------
// 定义存取函数
#define DEFINE_GETTER(typeName, varName) \
	const typeName& get_##varName() const { return varName; }

#define DEFINE_SETTER(typeName, varName) \
	void set_##varName(const typeName& varName) { this->varName = varName; }

#define DEFINE_GETTER_SETTER(typeName, varName) \
	DEFINE_GETTER(typeName, varName) \
	DEFINE_SETTER(typeName, varName)