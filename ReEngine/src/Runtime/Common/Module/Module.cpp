#include "Module.h"

#if PLATFORM_WINDOWS
#include <Windows.h>
#endif

#if defined(PLATFORM_WINDOWS)
void* CommonLib::LoadModuleLibrary(const T_CHAR* path)
{
    HMODULE h = LoadLibraryW(path);
    RE_ASSERT(h != nullptr);
    return (void*)h;
}
void* CommonLib::GetModuleExport(void* h, const char* name)
{
    void* f = GetProcAddress((HMODULE)h, name);
    RE_ASSERT(f != nullptr);
    return f;
}
#else
void* CommonLib::LoadModuleLibrary(const T_CHAR* path)
{
    void* h = dlopen(path, RTLD_LAZY | RTLD_LOCAL);
    assert(h != nullptr);
    return h;
}
void* CommonLib::GetModuleExport(void* h, const char* name)
{
    void* f = dlsym(h, name);
    assert(f != nullptr);
    return f;
}
#endif