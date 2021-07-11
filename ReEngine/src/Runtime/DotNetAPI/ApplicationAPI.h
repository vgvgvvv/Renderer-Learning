#pragma once

#include "DotNetAPI_API.h"

class DotNetAPI_API ApplicationAPI
{
public:

	static const char* GetProjectRoot();
	static void SetProjectRoot(const char* Root);

	static void SelectProjectRoot();
	
};