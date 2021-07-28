
#ifndef ShaderLab_API_H
#define ShaderLab_API_H

#ifdef ShaderLab_BUILT_AS_STATIC
#  define ShaderLab_API
#  define SHADERLAB_NO_EXPORT
#else
#  ifndef ShaderLab_API
#    ifdef ShaderLab_EXPORTS
        /* We are building this library */
#      define ShaderLab_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define ShaderLab_API __declspec(dllimport)
#    endif
#  endif

#  ifndef SHADERLAB_NO_EXPORT
#    define SHADERLAB_NO_EXPORT 
#  endif
#endif

#ifndef SHADERLAB_DEPRECATED
#  define SHADERLAB_DEPRECATED __declspec(deprecated)
#endif

#ifndef SHADERLAB_DEPRECATED_EXPORT
#  define SHADERLAB_DEPRECATED_EXPORT ShaderLab_API SHADERLAB_DEPRECATED
#endif

#ifndef SHADERLAB_DEPRECATED_NO_EXPORT
#  define SHADERLAB_DEPRECATED_NO_EXPORT SHADERLAB_NO_EXPORT SHADERLAB_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef SHADERLAB_NO_DEPRECATED
#    define SHADERLAB_NO_DEPRECATED
#  endif
#endif

#endif /* ShaderLab_API_H */
