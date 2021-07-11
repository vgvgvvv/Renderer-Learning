
#ifndef EditorGUI_API_H
#define EditorGUI_API_H

#ifdef EditorGUI_BUILT_AS_STATIC
#  define EditorGUI_API
#  define EDITORGUI_NO_EXPORT
#else
#  ifndef EditorGUI_API
#    ifdef EditorGUI_EXPORTS
        /* We are building this library */
#      define EditorGUI_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define EditorGUI_API __declspec(dllimport)
#    endif
#  endif

#  ifndef EDITORGUI_NO_EXPORT
#    define EDITORGUI_NO_EXPORT 
#  endif
#endif

#ifndef EDITORGUI_DEPRECATED
#  define EDITORGUI_DEPRECATED __declspec(deprecated)
#endif

#ifndef EDITORGUI_DEPRECATED_EXPORT
#  define EDITORGUI_DEPRECATED_EXPORT EditorGUI_API EDITORGUI_DEPRECATED
#endif

#ifndef EDITORGUI_DEPRECATED_NO_EXPORT
#  define EDITORGUI_DEPRECATED_NO_EXPORT EDITORGUI_NO_EXPORT EDITORGUI_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef EDITORGUI_NO_DEPRECATED
#    define EDITORGUI_NO_DEPRECATED
#  endif
#endif

#endif /* EditorGUI_API_H */
