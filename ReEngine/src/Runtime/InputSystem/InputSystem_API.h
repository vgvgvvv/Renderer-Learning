
#ifndef InputSystem_API_H
#define InputSystem_API_H

#ifdef InputSystem_BUILT_AS_STATIC
#  define InputSystem_API
#  define INPUTSYSTEM_NO_EXPORT
#else
#  ifndef InputSystem_API
#    ifdef InputSystem_EXPORTS
        /* We are building this library */
#      define InputSystem_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define InputSystem_API __declspec(dllimport)
#    endif
#  endif

#  ifndef INPUTSYSTEM_NO_EXPORT
#    define INPUTSYSTEM_NO_EXPORT 
#  endif
#endif

#ifndef INPUTSYSTEM_DEPRECATED
#  define INPUTSYSTEM_DEPRECATED __declspec(deprecated)
#endif

#ifndef INPUTSYSTEM_DEPRECATED_EXPORT
#  define INPUTSYSTEM_DEPRECATED_EXPORT InputSystem_API INPUTSYSTEM_DEPRECATED
#endif

#ifndef INPUTSYSTEM_DEPRECATED_NO_EXPORT
#  define INPUTSYSTEM_DEPRECATED_NO_EXPORT INPUTSYSTEM_NO_EXPORT INPUTSYSTEM_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef INPUTSYSTEM_NO_DEPRECATED
#    define INPUTSYSTEM_NO_DEPRECATED
#  endif
#endif

#endif /* InputSystem_API_H */
