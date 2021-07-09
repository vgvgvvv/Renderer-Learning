#pragma once
#include "TestOpenGL_API.h"

class TestOpenGL_API NetLog
{
public:
	static void Info(const char* info);
	static void Debug(const char* info);
	static void Warning(const char* info);
	static void Error(const char* info);
};
