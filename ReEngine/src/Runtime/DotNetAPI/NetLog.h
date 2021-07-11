#pragma once

#include "DotNetAPI_API.h"

class DotNetAPI_API NetLog
{
public:
	static void Info(const char* info);
	static void Debug(const char* info);
	static void Warning(const char* info);
	static void Error(const char* info);
};
