
#ifndef ReOpenGL_API_H
#define ReOpenGL_API_H

#ifdef ReOpenGL_BUILT_AS_STATIC
#  define ReOpenGL_API
#  define REOPENGL_NO_EXPORT
#else
#  ifndef ReOpenGL_API
#    ifdef ReOpenGL_EXPORTS
        /* We are building this library */
#      define ReOpenGL_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define ReOpenGL_API __declspec(dllimport)
#    endif
#  endif

#  ifndef REOPENGL_NO_EXPORT
#    define REOPENGL_NO_EXPORT 
#  endif
#endif

#ifndef REOPENGL_DEPRECATED
#  define REOPENGL_DEPRECATED __declspec(deprecated)
#endif

#ifndef REOPENGL_DEPRECATED_EXPORT
#  define REOPENGL_DEPRECATED_EXPORT ReOpenGL_API REOPENGL_DEPRECATED
#endif

#ifndef REOPENGL_DEPRECATED_NO_EXPORT
#  define REOPENGL_DEPRECATED_NO_EXPORT REOPENGL_NO_EXPORT REOPENGL_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef REOPENGL_NO_DEPRECATED
#    define REOPENGL_NO_DEPRECATED
#  endif
#endif

#endif /* ReOpenGL_API_H */
