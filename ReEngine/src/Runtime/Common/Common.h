#pragma once

#include <string>
#include "Logging/Log.h"
#include "CommonAssert.h"

#if defined(PLATFORM_WINDOWS)
#define CORECLR_DELEGATE_CALLTYPE __stdcall
#ifdef _WCHAR_T_DEFINED
typedef wchar_t char_t;
#else
typedef unsigned short char_t;
#endif
#else
#define CORECLR_DELEGATE_CALLTYPE
typedef char char_t;
#endif

using string_t = std::basic_string<char_t>;