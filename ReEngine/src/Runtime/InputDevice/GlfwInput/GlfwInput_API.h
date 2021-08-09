
#ifndef GlfwInput_API_H
#define GlfwInput_API_H

#ifdef GlfwInput_BUILT_AS_STATIC
#  define GlfwInput_API
#  define GLFWINPUT_NO_EXPORT
#else
#  ifndef GlfwInput_API
#    ifdef GlfwInput_EXPORTS
        /* We are building this library */
#      define GlfwInput_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define GlfwInput_API __declspec(dllimport)
#    endif
#  endif

#  ifndef GLFWINPUT_NO_EXPORT
#    define GLFWINPUT_NO_EXPORT 
#  endif
#endif

#ifndef GLFWINPUT_DEPRECATED
#  define GLFWINPUT_DEPRECATED __declspec(deprecated)
#endif

#ifndef GLFWINPUT_DEPRECATED_EXPORT
#  define GLFWINPUT_DEPRECATED_EXPORT GlfwInput_API GLFWINPUT_DEPRECATED
#endif

#ifndef GLFWINPUT_DEPRECATED_NO_EXPORT
#  define GLFWINPUT_DEPRECATED_NO_EXPORT GLFWINPUT_NO_EXPORT GLFWINPUT_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef GLFWINPUT_NO_DEPRECATED
#    define GLFWINPUT_NO_DEPRECATED
#  endif
#endif

#endif /* GlfwInput_API_H */
