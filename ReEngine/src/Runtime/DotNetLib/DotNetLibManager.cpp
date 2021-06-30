#include "DotNetLibManager.h"

// Standard headers
#include <stdio.h>
#include <stdint.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#include <iostream>


// Provided by the AppHost NuGet package and installed as an SDK pack
#include <nethost.h>

#ifdef PLATFORM_WINDOWS
#include <Windows.h>

#define STR(s) L ## s
#define CH(c) L ## c
#define DIR_SEPARATOR L'\\'

#else
#include <dlfcn.h>
#include <limits.h>

#define STR(s) s
#define CH(c) c
#define DIR_SEPARATOR '/'
#define MAX_PATH PATH_MAX

#endif

#include "Module/Module.h"
#include "Common.h"

//------------------------------------------------
// Public Methods
//------------------------------------------------

void DotNetLibManager::Init()
{
    RE_ASSERT_MSG(LoadHostfxr(), "Cannot Load Hostfxr lib");
}

void DotNetLibManager::Uninit()
{
	
}

bool DotNetLibManager::LoadAssembly(const T_String& configPath, DotNetAssembly* Assembly)
{
    load_assembly_and_get_function_pointer_fn load_assembly_and_get_function_pointer = nullptr;
    load_assembly_and_get_function_pointer = GetDotNetLoadAssemblyFunc(configPath.c_str());
	if(!load_assembly_and_get_function_pointer)
	{
        RE_ASSERT_MSG(load_assembly_and_get_function_pointer != nullptr, "Failure: get_dotnet_load_assembly()");
		return false;
	}
    Assembly->load_assembly_and_get_function_pointer = load_assembly_and_get_function_pointer;
    return true;
}

bool DotNetAssembly::GetFunctionPointer(const T_String& DotNetLibPath, const T_String& DotNetTypeName,
    const T_String& DotNetMethodName, EntryPointFunc Result) const
{
    int rc = load_assembly_and_get_function_pointer(
        DotNetLibPath.c_str(),
        DotNetTypeName.c_str(),
        DotNetMethodName.c_str(), /*method_name*/
        nullptr, /*delegate_type_name*/
        nullptr,
        (void**)(&Result));
    RE_ASSERT_MSG(rc == 0 && Result != nullptr, "Failure: load_assembly_and_get_function_pointer()");
    return rc == 0 && Result != nullptr;
}

//------------------------------------------------
// Private Methods
//------------------------------------------------

load_assembly_and_get_function_pointer_fn DotNetLibManager::GetDotNetLoadAssemblyFunc(const char_t* config_path)
{
    // Load .NET Core
    void* load_assembly_and_get_function_pointer = nullptr;
    hostfxr_handle cxt = nullptr;
    int rc = init_fptr(config_path, nullptr, &cxt);
    if (rc != 0 || cxt == nullptr)
    {
        RE_LOG_ERROR("DotNet", "Init failed:{0:#x}", rc);
        close_fptr(cxt);
        return nullptr;
    }

    // Get the load assembly function pointer
    rc = get_delegate_fptr(
        cxt,
        hdt_load_assembly_and_get_function_pointer,
        &load_assembly_and_get_function_pointer);
    if (rc != 0 || load_assembly_and_get_function_pointer == nullptr)
    {
        RE_LOG_ERROR("DotNet", "Get delegate failed:{0:#x}", rc);
    }

    close_fptr(cxt);
    return (load_assembly_and_get_function_pointer_fn)load_assembly_and_get_function_pointer;
}

bool DotNetLibManager::LoadHostfxr()
{
    // Pre-allocate a large buffer for the path to hostfxr
    char_t buffer[MAX_PATH];
    size_t buffer_size = sizeof(buffer) / sizeof(char_t);
    int rc = get_hostfxr_path(buffer, &buffer_size, nullptr);
    if (rc != 0)
        return false;

    // Load hostfxr and get desired exports
    void* lib = CommonLib::LoadModuleLibrary(buffer);
    init_fptr = (hostfxr_initialize_for_runtime_config_fn)
		CommonLib::GetModuleExport(lib, "hostfxr_initialize_for_runtime_config");
    get_delegate_fptr = (hostfxr_get_runtime_delegate_fn)
		CommonLib::GetModuleExport(lib, "hostfxr_get_runtime_delegate");
    close_fptr = (hostfxr_close_fn)
		CommonLib::GetModuleExport(lib, "hostfxr_close");

    return (init_fptr && get_delegate_fptr && close_fptr);
}


