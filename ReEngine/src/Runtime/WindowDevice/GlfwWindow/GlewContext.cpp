#include "GlewContext.h"

#include <iostream>
#include "OpenGL.h"
#include "CommonAssert.h"


void GlewContext::InitSingleton()
{
}

bool GlewContext::Init() const
{
    GLenum err = glewInit();
    if (err != GLEW_OK)
    {
        std::cout << glewGetErrorString(err) << std::endl;
        RE_ASSERT_MSG(false, "Failed to initialize GLAD");
        return false;
    }
    RE_LOG_INFO("Window", "Init Glew Context");
    return true;
}
