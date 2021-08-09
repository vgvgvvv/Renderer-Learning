
#ifndef GenericWindow_API_H
#define GenericWindow_API_H

#ifdef GenericWindow_BUILT_AS_STATIC
#  define GenericWindow_API
#  define GENERICWINDOW_NO_EXPORT
#else
#  ifndef GenericWindow_API
#    ifdef GenericWindow_EXPORTS
        /* We are building this library */
#      define GenericWindow_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define GenericWindow_API __declspec(dllimport)
#    endif
#  endif

#  ifndef GENERICWINDOW_NO_EXPORT
#    define GENERICWINDOW_NO_EXPORT 
#  endif
#endif

#ifndef GENERICWINDOW_DEPRECATED
#  define GENERICWINDOW_DEPRECATED __declspec(deprecated)
#endif

#ifndef GENERICWINDOW_DEPRECATED_EXPORT
#  define GENERICWINDOW_DEPRECATED_EXPORT GenericWindow_API GENERICWINDOW_DEPRECATED
#endif

#ifndef GENERICWINDOW_DEPRECATED_NO_EXPORT
#  define GENERICWINDOW_DEPRECATED_NO_EXPORT GENERICWINDOW_NO_EXPORT GENERICWINDOW_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef GENERICWINDOW_NO_DEPRECATED
#    define GENERICWINDOW_NO_DEPRECATED
#  endif
#endif

#endif /* GenericWindow_API_H */
