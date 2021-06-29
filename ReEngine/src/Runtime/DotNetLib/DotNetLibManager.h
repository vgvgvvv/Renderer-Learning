#pragma once

#include "coreclr_delegates.h"
#include "hostfxr.h"

class DotNetLibManager
{
public:

private:
	// <SnippetInitialize>
	// 获取DotNet Assembly的加载方法
	load_assembly_and_get_function_pointer_fn GetDotNetLoadAssemblyFunc(const char_t* config_path);

	// 加载Hostfxr库
	bool LoadHostfxr();

	// Globals to hold hostfxr exports
	hostfxr_initialize_for_runtime_config_fn init_fptr;
	hostfxr_get_runtime_delegate_fn get_delegate_fptr;
	hostfxr_close_fn close_fptr;

};
