
#ifndef DotNetLib_API_H
#define DotNetLib_API_H

#ifdef DotNetLib_BUILT_AS_STATIC
#  define DotNetLib_API
#  define DOTNETLIB_NO_EXPORT
#else
#  ifndef DotNetLib_API
#    ifdef DotNetLib_EXPORTS
        /* We are building this library */
#      define DotNetLib_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define DotNetLib_API __declspec(dllimport)
#    endif
#  endif

#  ifndef DOTNETLIB_NO_EXPORT
#    define DOTNETLIB_NO_EXPORT 
#  endif
#endif

#ifndef DOTNETLIB_DEPRECATED
#  define DOTNETLIB_DEPRECATED __declspec(deprecated)
#endif

#ifndef DOTNETLIB_DEPRECATED_EXPORT
#  define DOTNETLIB_DEPRECATED_EXPORT DotNetLib_API DOTNETLIB_DEPRECATED
#endif

#ifndef DOTNETLIB_DEPRECATED_NO_EXPORT
#  define DOTNETLIB_DEPRECATED_NO_EXPORT DOTNETLIB_NO_EXPORT DOTNETLIB_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef DOTNETLIB_NO_DEPRECATED
#    define DOTNETLIB_NO_DEPRECATED
#  endif
#endif

#endif /* DotNetLib_API_H */
