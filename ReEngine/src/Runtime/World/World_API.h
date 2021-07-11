
#ifndef World_API_H
#define World_API_H

#ifdef World_BUILT_AS_STATIC
#  define World_API
#  define WORLD_NO_EXPORT
#else
#  ifndef World_API
#    ifdef World_EXPORTS
        /* We are building this library */
#      define World_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define World_API __declspec(dllimport)
#    endif
#  endif

#  ifndef WORLD_NO_EXPORT
#    define WORLD_NO_EXPORT 
#  endif
#endif

#ifndef WORLD_DEPRECATED
#  define WORLD_DEPRECATED __declspec(deprecated)
#endif

#ifndef WORLD_DEPRECATED_EXPORT
#  define WORLD_DEPRECATED_EXPORT World_API WORLD_DEPRECATED
#endif

#ifndef WORLD_DEPRECATED_NO_EXPORT
#  define WORLD_DEPRECATED_NO_EXPORT WORLD_NO_EXPORT WORLD_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef WORLD_NO_DEPRECATED
#    define WORLD_NO_DEPRECATED
#  endif
#endif

#endif /* World_API_H */
