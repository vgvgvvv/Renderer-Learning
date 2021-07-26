
#ifndef GlobalAssets_API_H
#define GlobalAssets_API_H

#ifdef GlobalAssets_BUILT_AS_STATIC
#  define GlobalAssets_API
#  define GLOBALASSETS_NO_EXPORT
#else
#  ifndef GlobalAssets_API
#    ifdef GlobalAssets_EXPORTS
        /* We are building this library */
#      define GlobalAssets_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define GlobalAssets_API __declspec(dllimport)
#    endif
#  endif

#  ifndef GLOBALASSETS_NO_EXPORT
#    define GLOBALASSETS_NO_EXPORT 
#  endif
#endif

#ifndef GLOBALASSETS_DEPRECATED
#  define GLOBALASSETS_DEPRECATED __declspec(deprecated)
#endif

#ifndef GLOBALASSETS_DEPRECATED_EXPORT
#  define GLOBALASSETS_DEPRECATED_EXPORT GlobalAssets_API GLOBALASSETS_DEPRECATED
#endif

#ifndef GLOBALASSETS_DEPRECATED_NO_EXPORT
#  define GLOBALASSETS_DEPRECATED_NO_EXPORT GLOBALASSETS_NO_EXPORT GLOBALASSETS_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef GLOBALASSETS_NO_DEPRECATED
#    define GLOBALASSETS_NO_DEPRECATED
#  endif
#endif

#endif /* GlobalAssets_API_H */
