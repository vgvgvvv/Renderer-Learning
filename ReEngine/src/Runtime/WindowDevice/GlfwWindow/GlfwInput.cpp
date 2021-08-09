#include "GlfwInput.h"
#include "OpenGL.h"
#include <map>


static Vector2 mousePosition;
static float mouseScrollX;
static float mouseScrollY;
static std::map<MouseButtonType, ButtonState> mouseButtonState;
static std::map<KeyBoardType, ButtonState> keyBoardButtonState;

static void cursor_position_callback(GLFWwindow* window, double xpos, double ypos)
{
	mousePosition = Vector2(xpos, ypos);
}

void scroll_callback(GLFWwindow* window, double xoffset, double yoffset)
{
	mouseScrollX = xoffset;
	mouseScrollY = yoffset;
}

void GlfwInput::Init()
{
	auto window = GlfwContext::Get().GetWindow();
	glfwSetCursorPosCallback(window, cursor_position_callback);
	glfwSetScrollCallback(window, scroll_callback);
}

Vector2 GlfwInput::GetMousePosition()
{
	return mousePosition;
}

float GlfwInput::GetMouseScrollX()
{
	return mouseScrollX;
}

float GlfwInput::GetMouseScrollY()
{
	return mouseScrollY;
}


const ButtonState& GlfwInput::GetMouseState(MouseButtonType type)
{
	auto& state = mouseButtonState.at(type);
	return state;
}

const ButtonState& GlfwInput::GetKeyState(KeyBoardType type)
{
	auto& state = keyBoardButtonState.at(type);
	return state;
}

void GlfwInput::Update(float deltaTime)
{
}

