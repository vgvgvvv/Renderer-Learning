
#ifndef ClassLib_API_H
#define ClassLib_API_H

#ifdef ClassLib_BUILT_AS_STATIC
#  define ClassLib_API
#  define CLASSLIB_NO_EXPORT
#else
#  ifndef ClassLib_API
#    ifdef ClassLib_EXPORTS
        /* We are building this library */
#      define ClassLib_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define ClassLib_API __declspec(dllimport)
#    endif
#  endif

#  ifndef CLASSLIB_NO_EXPORT
#    define CLASSLIB_NO_EXPORT 
#  endif
#endif

#ifndef CLASSLIB_DEPRECATED
#  define CLASSLIB_DEPRECATED __declspec(deprecated)
#endif

#ifndef CLASSLIB_DEPRECATED_EXPORT
#  define CLASSLIB_DEPRECATED_EXPORT ClassLib_API CLASSLIB_DEPRECATED
#endif

#ifndef CLASSLIB_DEPRECATED_NO_EXPORT
#  define CLASSLIB_DEPRECATED_NO_EXPORT CLASSLIB_NO_EXPORT CLASSLIB_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef CLASSLIB_NO_DEPRECATED
#    define CLASSLIB_NO_DEPRECATED
#  endif
#endif

#endif /* ClassLib_API_H */
