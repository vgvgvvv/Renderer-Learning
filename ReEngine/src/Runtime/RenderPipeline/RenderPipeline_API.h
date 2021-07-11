
#ifndef RenderPipeline_API_H
#define RenderPipeline_API_H

#ifdef RenderPipeline_BUILT_AS_STATIC
#  define RenderPipeline_API
#  define RENDERPIPELINE_NO_EXPORT
#else
#  ifndef RenderPipeline_API
#    ifdef RenderPipeline_EXPORTS
        /* We are building this library */
#      define RenderPipeline_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define RenderPipeline_API __declspec(dllimport)
#    endif
#  endif

#  ifndef RENDERPIPELINE_NO_EXPORT
#    define RENDERPIPELINE_NO_EXPORT 
#  endif
#endif

#ifndef RENDERPIPELINE_DEPRECATED
#  define RENDERPIPELINE_DEPRECATED __declspec(deprecated)
#endif

#ifndef RENDERPIPELINE_DEPRECATED_EXPORT
#  define RENDERPIPELINE_DEPRECATED_EXPORT RenderPipeline_API RENDERPIPELINE_DEPRECATED
#endif

#ifndef RENDERPIPELINE_DEPRECATED_NO_EXPORT
#  define RENDERPIPELINE_DEPRECATED_NO_EXPORT RENDERPIPELINE_NO_EXPORT RENDERPIPELINE_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef RENDERPIPELINE_NO_DEPRECATED
#    define RENDERPIPELINE_NO_DEPRECATED
#  endif
#endif

#endif /* RenderPipeline_API_H */
