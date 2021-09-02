
#ifndef TestDll_API_H
#define TestDll_API_H

#ifdef TestDll_BUILT_AS_STATIC
#  define TestDll_API
#  define TESTDLL_NO_EXPORT
#else
#  ifndef TestDll_API
#    ifdef TestDll_EXPORTS
        /* We are building this library */
#      define TestDll_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define TestDll_API __declspec(dllimport)
#    endif
#  endif

#  ifndef TESTDLL_NO_EXPORT
#    define TESTDLL_NO_EXPORT 
#  endif
#endif

#ifndef TESTDLL_DEPRECATED
#  define TESTDLL_DEPRECATED __declspec(deprecated)
#endif

#ifndef TESTDLL_DEPRECATED_EXPORT
#  define TESTDLL_DEPRECATED_EXPORT TestDll_API TESTDLL_DEPRECATED
#endif

#ifndef TESTDLL_DEPRECATED_NO_EXPORT
#  define TESTDLL_DEPRECATED_NO_EXPORT TESTDLL_NO_EXPORT TESTDLL_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef TESTDLL_NO_DEPRECATED
#    define TESTDLL_NO_DEPRECATED
#  endif
#endif

#endif /* TestDll_API_H */
