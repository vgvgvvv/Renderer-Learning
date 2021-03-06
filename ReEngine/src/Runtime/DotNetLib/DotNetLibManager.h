#pragma once

#include "coreclr_delegates.h"
#include "hostfxr.h"
#include "Common.h"
#include "DotNetLib_API.h"

class DotNetAssembly;

class DotNetLib_API DotNetLibManager
{
public:
	~DotNetLibManager();
	void Init();
	void Uninit();

	bool LoadAssembly(const std::wstring& configPath, DotNetAssembly* Assembly);

private:
	// <SnippetInitialize>
	// 获取DotNet Assembly的加载方法
	load_assembly_and_get_function_pointer_fn GetDotNetLoadAssemblyFunc(const char_t* config_path);

	// 加载Hostfxr库
	bool LoadHostfxr();

	// Globals to hold hostfxr exports
	hostfxr_initialize_for_runtime_config_fn init_fptr = nullptr;
	hostfxr_get_runtime_delegate_fn get_delegate_fptr = nullptr;
	hostfxr_close_fn close_fptr = nullptr;
	hostfxr_set_error_writer_fn set_error_writer_fptr = nullptr;
};

class DotNetLib_API DotNetAssembly
{
	friend DotNetLibManager;
public:

	template<typename EntryPointFuncType>
	bool GetCustomFunctionPointer(
		const std::wstring& DotNetLibPath,
		const std::wstring& DotNetTypeName,
		const std::wstring& DotNetMethodName,
		const std::wstring& DotNetDelegateTypeName,
		EntryPointFuncType* Result);

	typedef component_entry_point_fn EntryPointFunc;
	
	bool GetFunctionPointer(const std::wstring& DotNetLibPath,
		const std::wstring& DotNetTypeName,
		const std::wstring& DotNetMethodName,
		EntryPointFunc* Result) const;
	
private:
	load_assembly_and_get_function_pointer_fn load_assembly_and_get_function_pointer = nullptr;
};

template <typename EntryPointFuncType>
bool DotNetAssembly::GetCustomFunctionPointer(
	const std::wstring& DotNetLibPath,
	const std::wstring& DotNetTypeName,
	const std::wstring& DotNetMethodName,
	const std::wstring& DotNetDelegateTypeName,
 	EntryPointFuncType* Result)
{
	int rc = load_assembly_and_get_function_pointer(
		DotNetLibPath.c_str(),
		DotNetTypeName.c_str(),
		DotNetMethodName.c_str(), /*method_name*/
		DotNetDelegateTypeName.c_str(), /*delegate_type_name*/
		nullptr,
		(void**)(Result));
	RE_ASSERT_MSG(rc == 0 && *Result != nullptr, "Failure: load_assembly_and_get_function_pointer()");
	return rc == 0 && *Result != nullptr;
}

