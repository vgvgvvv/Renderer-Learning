#pragma once

#include "Logging/Log.h"


#if _DEBUG
#define RE_ASSERT(x) if(!(x)) __debugbreak();
#define RE_ASSERT_MSG(x, msg, ...) \
if(!(x)) \
{ \
	RE_LOG_ERROR("ASSERT", msg, __VA_ARGS__); \
	__debugbreak(); \
}
#else
#define RE_ASSERT(x)
#define RE_ASSERT_MSG(x, msg, ...)
#endif