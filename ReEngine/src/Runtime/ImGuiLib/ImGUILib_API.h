
#ifndef ImGUILib_API_H
#define ImGUILib_API_H

#ifdef ImGUILib_BUILT_AS_STATIC
#  define ImGUILib_API
#  define IMGUILIB_NO_EXPORT
#else
#  ifndef ImGUILib_API
#    ifdef ImGUILib_EXPORTS
        /* We are building this library */
#      define ImGUILib_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define ImGUILib_API __declspec(dllimport)
#    endif
#  endif

#  ifndef IMGUILIB_NO_EXPORT
#    define IMGUILIB_NO_EXPORT 
#  endif
#endif

#ifndef IMGUILIB_DEPRECATED
#  define IMGUILIB_DEPRECATED __declspec(deprecated)
#endif

#ifndef IMGUILIB_DEPRECATED_EXPORT
#  define IMGUILIB_DEPRECATED_EXPORT ImGUILib_API IMGUILIB_DEPRECATED
#endif

#ifndef IMGUILIB_DEPRECATED_NO_EXPORT
#  define IMGUILIB_DEPRECATED_NO_EXPORT IMGUILIB_NO_EXPORT IMGUILIB_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef IMGUILIB_NO_DEPRECATED
#    define IMGUILIB_NO_DEPRECATED
#  endif
#endif

#endif /* ImGUILib_API_H */
