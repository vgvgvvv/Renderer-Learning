#include "GladContext.h"
#include "OpenGL.h"
#include "Common.h"

bool GladContext::Init() const
{
    if (!gladLoadGLLoader((GLADloadproc)glfwGetProcAddress))
    {
        RE_ASSERT_MSG(false, "Failed to initialize GLAD");
        return false;
    }
    return true;
}
