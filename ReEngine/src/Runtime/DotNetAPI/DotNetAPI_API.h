
#ifndef DotNetAPI_API_H
#define DotNetAPI_API_H

#ifdef DotNetAPI_BUILT_AS_STATIC
#  define DotNetAPI_API
#  define DOTNETAPI_NO_EXPORT
#else
#  ifndef DotNetAPI_API
#    ifdef DotNetAPI_EXPORTS
        /* We are building this library */
#      define DotNetAPI_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define DotNetAPI_API __declspec(dllimport)
#    endif
#  endif

#  ifndef DOTNETAPI_NO_EXPORT
#    define DOTNETAPI_NO_EXPORT 
#  endif
#endif

#ifndef DOTNETAPI_DEPRECATED
#  define DOTNETAPI_DEPRECATED __declspec(deprecated)
#endif

#ifndef DOTNETAPI_DEPRECATED_EXPORT
#  define DOTNETAPI_DEPRECATED_EXPORT DotNetAPI_API DOTNETAPI_DEPRECATED
#endif

#ifndef DOTNETAPI_DEPRECATED_NO_EXPORT
#  define DOTNETAPI_DEPRECATED_NO_EXPORT DOTNETAPI_NO_EXPORT DOTNETAPI_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef DOTNETAPI_NO_DEPRECATED
#    define DOTNETAPI_NO_DEPRECATED
#  endif
#endif

#endif /* DotNetAPI_API_H */
