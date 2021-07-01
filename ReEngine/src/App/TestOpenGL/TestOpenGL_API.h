
#ifndef TestOpenGL_API_H
#define TestOpenGL_API_H

#ifdef TestOpenGL_BUILT_AS_STATIC
#  define TestOpenGL_API
#  define TESTOPENGL_NO_EXPORT
#else
#  ifndef TestOpenGL_API
#    ifdef TestOpenGL_EXPORTS
        /* We are building this library */
#      define TestOpenGL_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define TestOpenGL_API __declspec(dllimport)
#    endif
#  endif

#  ifndef TESTOPENGL_NO_EXPORT
#    define TESTOPENGL_NO_EXPORT 
#  endif
#endif

#ifndef TESTOPENGL_DEPRECATED
#  define TESTOPENGL_DEPRECATED __declspec(deprecated)
#endif

#ifndef TESTOPENGL_DEPRECATED_EXPORT
#  define TESTOPENGL_DEPRECATED_EXPORT TestOpenGL_API TESTOPENGL_DEPRECATED
#endif

#ifndef TESTOPENGL_DEPRECATED_NO_EXPORT
#  define TESTOPENGL_DEPRECATED_NO_EXPORT TESTOPENGL_NO_EXPORT TESTOPENGL_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef TESTOPENGL_NO_DEPRECATED
#    define TESTOPENGL_NO_DEPRECATED
#  endif
#endif

#endif /* TestOpenGL_API_H */
