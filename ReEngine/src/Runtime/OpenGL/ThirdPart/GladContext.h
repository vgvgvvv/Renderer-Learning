#pragma once
#include "Singleton.h"

class GladContext
{
	DEFINE_SINGLETON(GladContext);
public:
	bool Init() const;
};