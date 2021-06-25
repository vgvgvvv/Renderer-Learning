#include "GlfwContext.h"

void framebuffer_size_callback(GLFWwindow* window, int width, int height);

bool GlfwContext::Init()
{
	/* Initialize the library */
    if (!glfwInit())
    {
        return false;
    }

    glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
    glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3);
    glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

#ifdef __APPLE__
    glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);
#endif
	
    /* Create a windowed mode window and its OpenGL context */
    window = glfwCreateWindow(640, 480, "Hello World", NULL, NULL);

    if (!window)
    {
        glfwTerminate();
        return false;
    }

    /* Make the window's context current */
    glfwMakeContextCurrent(window);
    glfwSetFramebufferSizeCallback(window, framebuffer_size_callback);


    return true;
}

bool GlfwContext::ShouldQuit()
{
    return glfwWindowShouldClose(window);
}

bool GlfwContext::ShutDown()
{
    glfwTerminate();
    return true;
}

void GlfwContext::SwapBuffer()
{
    glfwSwapBuffers(window);
}

void GlfwContext::PollEvents()
{
    glfwPollEvents();
}



void framebuffer_size_callback(GLFWwindow* window, int width, int height)
{
    glViewport(0, 0, width, height);
}