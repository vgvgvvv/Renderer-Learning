
#ifndef GlfwWindow_API_H
#define GlfwWindow_API_H

#ifdef GlfwWindow_BUILT_AS_STATIC
#  define GlfwWindow_API
#  define GLFWWINDOW_NO_EXPORT
#else
#  ifndef GlfwWindow_API
#    ifdef GlfwWindow_EXPORTS
        /* We are building this library */
#      define GlfwWindow_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define GlfwWindow_API __declspec(dllimport)
#    endif
#  endif

#  ifndef GLFWWINDOW_NO_EXPORT
#    define GLFWWINDOW_NO_EXPORT 
#  endif
#endif

#ifndef GLFWWINDOW_DEPRECATED
#  define GLFWWINDOW_DEPRECATED __declspec(deprecated)
#endif

#ifndef GLFWWINDOW_DEPRECATED_EXPORT
#  define GLFWWINDOW_DEPRECATED_EXPORT GlfwWindow_API GLFWWINDOW_DEPRECATED
#endif

#ifndef GLFWWINDOW_DEPRECATED_NO_EXPORT
#  define GLFWWINDOW_DEPRECATED_NO_EXPORT GLFWWINDOW_NO_EXPORT GLFWWINDOW_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef GLFWWINDOW_NO_DEPRECATED
#    define GLFWWINDOW_NO_DEPRECATED
#  endif
#endif

#endif /* GlfwWindow_API_H */
