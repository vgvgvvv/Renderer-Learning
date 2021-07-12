#pragma once

#include "Singleton.h"

class GlewContext
{
	DEFINE_SINGLETON(GlewContext);
public:
	bool Init() const;
};