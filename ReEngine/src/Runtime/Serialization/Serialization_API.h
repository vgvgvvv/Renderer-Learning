
#ifndef Serialization_API_H
#define Serialization_API_H

#ifdef Serialization_BUILT_AS_STATIC
#  define Serialization_API
#  define SERIALIZATION_NO_EXPORT
#else
#  ifndef Serialization_API
#    ifdef Serialization_EXPORTS
        /* We are building this library */
#      define Serialization_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define Serialization_API __declspec(dllimport)
#    endif
#  endif

#  ifndef SERIALIZATION_NO_EXPORT
#    define SERIALIZATION_NO_EXPORT 
#  endif
#endif

#ifndef SERIALIZATION_DEPRECATED
#  define SERIALIZATION_DEPRECATED __declspec(deprecated)
#endif

#ifndef SERIALIZATION_DEPRECATED_EXPORT
#  define SERIALIZATION_DEPRECATED_EXPORT Serialization_API SERIALIZATION_DEPRECATED
#endif

#ifndef SERIALIZATION_DEPRECATED_NO_EXPORT
#  define SERIALIZATION_DEPRECATED_NO_EXPORT SERIALIZATION_NO_EXPORT SERIALIZATION_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef SERIALIZATION_NO_DEPRECATED
#    define SERIALIZATION_NO_DEPRECATED
#  endif
#endif

#endif /* Serialization_API_H */
