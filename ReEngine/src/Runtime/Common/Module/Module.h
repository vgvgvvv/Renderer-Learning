#pragma once

#if defined(_WIN32)
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

namespace CommonLib
{
    // Forward declarations
    void* LoadModuleLibrary(const char_t*);
    void* GetModuleExport(void*, const char*);
}
