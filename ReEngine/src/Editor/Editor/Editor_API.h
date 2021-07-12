
#ifndef Editor_API_H
#define Editor_API_H

#ifdef Editor_BUILT_AS_STATIC
#  define Editor_API
#  define EDITOR_NO_EXPORT
#else
#  ifndef Editor_API
#    ifdef Editor_EXPORTS
        /* We are building this library */
#      define Editor_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define Editor_API __declspec(dllimport)
#    endif
#  endif

#  ifndef EDITOR_NO_EXPORT
#    define EDITOR_NO_EXPORT 
#  endif
#endif

#ifndef EDITOR_DEPRECATED
#  define EDITOR_DEPRECATED __declspec(deprecated)
#endif

#ifndef EDITOR_DEPRECATED_EXPORT
#  define EDITOR_DEPRECATED_EXPORT Editor_API EDITOR_DEPRECATED
#endif

#ifndef EDITOR_DEPRECATED_NO_EXPORT
#  define EDITOR_DEPRECATED_NO_EXPORT EDITOR_NO_EXPORT EDITOR_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef EDITOR_NO_DEPRECATED
#    define EDITOR_NO_DEPRECATED
#  endif
#endif

#endif /* Editor_API_H */
