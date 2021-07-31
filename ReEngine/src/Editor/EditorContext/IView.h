#pragma once
#include "ClassInfo.h"


class IView
{
public:
	bool isShow = true;
	virtual ~IView() = default;
	virtual const std::string& GetTitle() const = 0;
	virtual void OnInit() = 0;
	virtual void OnGUI() = 0;
	virtual void ShutDown() = 0;
};