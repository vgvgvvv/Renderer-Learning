
#ifndef Win32Windows_API_H
#define Win32Windows_API_H

#ifdef Win32Windows_BUILT_AS_STATIC
#  define Win32Windows_API
#  define WIN32WINDOWS_NO_EXPORT
#else
#  ifndef Win32Windows_API
#    ifdef Win32Windows_EXPORTS
        /* We are building this library */
#      define Win32Windows_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define Win32Windows_API __declspec(dllimport)
#    endif
#  endif

#  ifndef WIN32WINDOWS_NO_EXPORT
#    define WIN32WINDOWS_NO_EXPORT 
#  endif
#endif

#ifndef WIN32WINDOWS_DEPRECATED
#  define WIN32WINDOWS_DEPRECATED __declspec(deprecated)
#endif

#ifndef WIN32WINDOWS_DEPRECATED_EXPORT
#  define WIN32WINDOWS_DEPRECATED_EXPORT Win32Windows_API WIN32WINDOWS_DEPRECATED
#endif

#ifndef WIN32WINDOWS_DEPRECATED_NO_EXPORT
#  define WIN32WINDOWS_DEPRECATED_NO_EXPORT WIN32WINDOWS_NO_EXPORT WIN32WINDOWS_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef WIN32WINDOWS_NO_DEPRECATED
#    define WIN32WINDOWS_NO_DEPRECATED
#  endif
#endif

#endif /* Win32Windows_API_H */
