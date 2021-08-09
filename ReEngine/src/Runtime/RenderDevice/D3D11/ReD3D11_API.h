
#ifndef ReD3D11_API_H
#define ReD3D11_API_H

#ifdef ReD3D11_BUILT_AS_STATIC
#  define ReD3D11_API
#  define RED3D11_NO_EXPORT
#else
#  ifndef ReD3D11_API
#    ifdef ReD3D11_EXPORTS
        /* We are building this library */
#      define ReD3D11_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define ReD3D11_API __declspec(dllimport)
#    endif
#  endif

#  ifndef RED3D11_NO_EXPORT
#    define RED3D11_NO_EXPORT 
#  endif
#endif

#ifndef RED3D11_DEPRECATED
#  define RED3D11_DEPRECATED __declspec(deprecated)
#endif

#ifndef RED3D11_DEPRECATED_EXPORT
#  define RED3D11_DEPRECATED_EXPORT ReD3D11_API RED3D11_DEPRECATED
#endif

#ifndef RED3D11_DEPRECATED_NO_EXPORT
#  define RED3D11_DEPRECATED_NO_EXPORT RED3D11_NO_EXPORT RED3D11_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef RED3D11_NO_DEPRECATED
#    define RED3D11_NO_DEPRECATED
#  endif
#endif

#endif /* ReD3D11_API_H */
