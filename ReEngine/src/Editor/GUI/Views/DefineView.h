#pragma once
#include "ClassInfo.h"
#include <string>

#define DEFINE_VIEW(className, viewName) \
	public:\
		const std::string& GetTitle() const override;\
		void OnInit() override;\
		void OnGUI(float deltaTime) override;\
		void ShutDown() override;\


#define DEFINE_VIEW_IMP(className, viewName) \
	static std::string title = #viewName;\
	const std::string& className::GetTitle() const\
	{\
		return title;\
	}