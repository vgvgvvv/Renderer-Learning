
#ifndef EditorContext_API_H
#define EditorContext_API_H

#ifdef EditorContext_BUILT_AS_STATIC
#  define EditorContext_API
#  define EDITORCONTEXT_NO_EXPORT
#else
#  ifndef EditorContext_API
#    ifdef EditorContext_EXPORTS
        /* We are building this library */
#      define EditorContext_API __declspec(dllexport)
#    else
        /* We are using this library */
#      define EditorContext_API __declspec(dllimport)
#    endif
#  endif

#  ifndef EDITORCONTEXT_NO_EXPORT
#    define EDITORCONTEXT_NO_EXPORT 
#  endif
#endif

#ifndef EDITORCONTEXT_DEPRECATED
#  define EDITORCONTEXT_DEPRECATED __declspec(deprecated)
#endif

#ifndef EDITORCONTEXT_DEPRECATED_EXPORT
#  define EDITORCONTEXT_DEPRECATED_EXPORT EditorContext_API EDITORCONTEXT_DEPRECATED
#endif

#ifndef EDITORCONTEXT_DEPRECATED_NO_EXPORT
#  define EDITORCONTEXT_DEPRECATED_NO_EXPORT EDITORCONTEXT_NO_EXPORT EDITORCONTEXT_DEPRECATED
#endif

#if 0 /* DEFINE_NO_DEPRECATED */
#  ifndef EDITORCONTEXT_NO_DEPRECATED
#    define EDITORCONTEXT_NO_DEPRECATED
#  endif
#endif

#endif /* EditorContext_API_H */
