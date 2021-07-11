
#ifndef CommonLib_API_H
#define CommonLib_API_H

#ifdef CommonLib_BUILT_AS_STATIC
#  define CommonLib_API
#  define COMMONLIB_NO_EXPORT
#else
#  ifndef CommonLib_API
#    ifdef CommonLib_EXPORTS
        /* We are building this library */
#      define CommonLib_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define CommonLib_API __declspec(dllimport)
#    endif
#  endif

#  ifndef COMMONLIB_NO_EXPORT
#    define COMMONLIB_NO_EXPORT 
#  endif
#endif

#ifndef COMMONLIB_DEPRECATED
#  define COMMONLIB_DEPRECATED __declspec(deprecated)
#endif

#ifndef COMMONLIB_DEPRECATED_EXPORT
#  define COMMONLIB_DEPRECATED_EXPORT CommonLib_API COMMONLIB_DEPRECATED
#endif

#ifndef COMMONLIB_DEPRECATED_NO_EXPORT
#  define COMMONLIB_DEPRECATED_NO_EXPORT COMMONLIB_NO_EXPORT COMMONLIB_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef COMMONLIB_NO_DEPRECATED
#    define COMMONLIB_NO_DEPRECATED
#  endif
#endif

#endif /* CommonLib_API_H */
