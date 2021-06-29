#pragma once



namespace CommonLib
{
    // Forward declarations
    void* LoadModuleLibrary(const char_t*);
    void* GetModuleExport(void*, const char*);
}
