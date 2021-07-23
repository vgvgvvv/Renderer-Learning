
#ifndef Assets_API_H
#define Assets_API_H

#ifdef Assets_BUILT_AS_STATIC
#  define Assets_API
#  define ASSETS_NO_EXPORT
#else
#  ifndef Assets_API
#    ifdef Assets_EXPORTS
        /* We are building this library */
#      define Assets_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define Assets_API __declspec(dllimport)
#    endif
#  endif

#  ifndef ASSETS_NO_EXPORT
#    define ASSETS_NO_EXPORT 
#  endif
#endif

#ifndef ASSETS_DEPRECATED
#  define ASSETS_DEPRECATED __declspec(deprecated)
#endif

#ifndef ASSETS_DEPRECATED_EXPORT
#  define ASSETS_DEPRECATED_EXPORT Assets_API ASSETS_DEPRECATED
#endif

#ifndef ASSETS_DEPRECATED_NO_EXPORT
#  define ASSETS_DEPRECATED_NO_EXPORT ASSETS_NO_EXPORT ASSETS_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef ASSETS_NO_DEPRECATED
#    define ASSETS_NO_DEPRECATED
#  endif
#endif

#endif /* Assets_API_H */
