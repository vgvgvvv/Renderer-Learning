#include "GenericWindow.h"

#include "Misc/GlobalContext.h"

static StaticGlobalContextValue WindowClassName("WindowClassName", "GlfwOpenGLWindow");

DEFINE_CLASS_IMP_BEGIN(IGenericWindow, ClassFlag::None)
DEFINE_CLASS_IMP_END()