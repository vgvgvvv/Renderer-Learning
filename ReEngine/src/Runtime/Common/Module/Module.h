#pragma once

#include "Common.h"
#include "CommonLib_API.h"

namespace CommonLib
{
    // Forward declarations
    CommonLib_API void* LoadModuleLibrary(const T_CHAR*);
    CommonLib_API void* GetModuleExport(void*, const char*);
}
