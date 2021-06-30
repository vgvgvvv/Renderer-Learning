#pragma once

#include "Common.h"

namespace CommonLib
{
    // Forward declarations
    void* LoadModuleLibrary(const T_CHAR*);
    void* GetModuleExport(void*, const char*);
}
