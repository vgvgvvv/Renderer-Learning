
#ifndef Core_API_H
#define Core_API_H

#ifdef Core_BUILT_AS_STATIC
#  define Core_API
#  define CORE_NO_EXPORT
#else
#  ifndef Core_API
#    ifdef Core_EXPORTS
        /* We are building this library */
#      define Core_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define Core_API __declspec(dllimport)
#    endif
#  endif

#  ifndef CORE_NO_EXPORT
#    define CORE_NO_EXPORT 
#  endif
#endif

#ifndef CORE_DEPRECATED
#  define CORE_DEPRECATED __declspec(deprecated)
#endif

#ifndef CORE_DEPRECATED_EXPORT
#  define CORE_DEPRECATED_EXPORT Core_API CORE_DEPRECATED
#endif

#ifndef CORE_DEPRECATED_NO_EXPORT
#  define CORE_DEPRECATED_NO_EXPORT CORE_NO_EXPORT CORE_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef CORE_NO_DEPRECATED
#    define CORE_NO_DEPRECATED
#  endif
#endif

#endif /* Core_API_H */
