#include "GlfwContext.h"

#include "Logging/Log.h"


void framebuffer_size_callback(GLFWwindow* window, int width, int height);
static void glfw_error_callback(int error, const char* description);

GlfwInitDesc::GlfwInitDesc()
{
    Width = 640;
    Height = 480;
    Title = "Glfw Windows";
}

bool GlfwContext::Init(const GlfwInitDesc& desc)
{
    glfwSetErrorCallback(glfw_error_callback);
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
    window = glfwCreateWindow(desc.Width, desc.Height, desc.Title.c_str(), nullptr, nullptr);

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

bool GlfwContext::ShouldQuit() const
{
    return glfwWindowShouldClose(window);
}

bool GlfwContext::ShutDown() const
{
    glfwTerminate();
    return true;
}

void GlfwContext::SwapBuffer() const
{
    glfwSwapBuffers(window);
}

void GlfwContext::PollEvents() const
{
    glfwPollEvents();
}


void GlfwContext::ProcessEvent() const
{
    if (glfwGetKey(window, GLFW_KEY_ESCAPE) == GLFW_PRESS)
        glfwSetWindowShouldClose(window, true);
}


GLFWwindow* GlfwContext::GetWindow() const
{
    return window;
}

void framebuffer_size_callback(GLFWwindow* window, int width, int height)
{
    glViewport(0, 0, width, height);
}

static void glfw_error_callback(int error, const char* description)
{
	RE_LOG_ERROR("Glfw", "Glfw Error {0}: {1}\n", error, description)
}