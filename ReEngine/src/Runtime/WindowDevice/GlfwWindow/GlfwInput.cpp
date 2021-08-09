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

static void scroll_callback(GLFWwindow* window, double xoffset, double yoffset)
{
	mouseScrollX = xoffset;
	mouseScrollY = yoffset;
}

static MouseButtonType GLFWMouseIDToMouseButtonType(int button)
{
	switch (button)
	{
	case GLFW_MOUSE_BUTTON_LEFT		: return MouseButtonType::MOUSE_LEFT;
	case GLFW_MOUSE_BUTTON_RIGHT	: return MouseButtonType::MOUSE_RIGHT;
	case GLFW_MOUSE_BUTTON_MIDDLE	: return MouseButtonType::MOUSE_MID;
	default							: return MouseButtonType::MOUSE_LEFT;
	}
}

static void mouse_button_callback(GLFWwindow* window, int button, int action, int mods)
{
	
	auto type = GLFWMouseIDToMouseButtonType(button);
	auto& state = mouseButtonState.at(type);
	if(action == GLFW_PRESS)
	{
		if(state.isDown)
		{
			state.isDownPrevious = true;
		}
		state.isDown = true;
	}else
	{
		if(!state.isDown && state.isDownPrevious)
		{
			state.isDownPrevious = false;
		}
		state.isDown = false;
	}
	
}

#define KEY_CASE(GlfwId, KeyType) case GlfwId           : return KeyBoardType::KeyType;

static KeyBoardType GLFWKeyBoardIDToKeyBoardType(int button)
{
	switch (button)
	{
		KEY_CASE(GLFW_KEY_UNKNOWN,				KEY_UNKNOWN)
		KEY_CASE(GLFW_KEY_SPACE,				KEY_SPACE)
		KEY_CASE(GLFW_KEY_APOSTROPHE,			KEY_APOSTROPHE)
		KEY_CASE(GLFW_KEY_COMMA,				KEY_COMMA)
		KEY_CASE(GLFW_KEY_MINUS,				KEY_MINUS)
		KEY_CASE(GLFW_KEY_PERIOD,				KEY_PERIOD)
		KEY_CASE(GLFW_KEY_SLASH,				KEY_SLASH)
		KEY_CASE(GLFW_KEY_0,					KEY_0)
		KEY_CASE(GLFW_KEY_1,					KEY_1)
		KEY_CASE(GLFW_KEY_2,					KEY_2)
		KEY_CASE(GLFW_KEY_3,					KEY_3)
		KEY_CASE(GLFW_KEY_4,					KEY_4)
		KEY_CASE(GLFW_KEY_5,					KEY_5)
		KEY_CASE(GLFW_KEY_6,					KEY_6)
		KEY_CASE(GLFW_KEY_7,					KEY_7)
		KEY_CASE(GLFW_KEY_8,					KEY_8)
		KEY_CASE(GLFW_KEY_9,					KEY_9)
		KEY_CASE(GLFW_KEY_SEMICOLON,			KEY_SEMICOLON)
		KEY_CASE(GLFW_KEY_EQUAL,				KEY_EQUAL)
		KEY_CASE(GLFW_KEY_A,					KEY_A)
		KEY_CASE(GLFW_KEY_B,					KEY_B)
		KEY_CASE(GLFW_KEY_C,					KEY_C)
		KEY_CASE(GLFW_KEY_D,					KEY_D)
		KEY_CASE(GLFW_KEY_E,					KEY_E)
		KEY_CASE(GLFW_KEY_F,					KEY_F)
		KEY_CASE(GLFW_KEY_G,					KEY_G)
		KEY_CASE(GLFW_KEY_H,					KEY_H)
		KEY_CASE(GLFW_KEY_I,					KEY_I)
		KEY_CASE(GLFW_KEY_J,					KEY_J)
		KEY_CASE(GLFW_KEY_K,					KEY_K)
		KEY_CASE(GLFW_KEY_L,					KEY_L)
		KEY_CASE(GLFW_KEY_M,					KEY_M)
		KEY_CASE(GLFW_KEY_N,					KEY_N)
		KEY_CASE(GLFW_KEY_O,					KEY_O)
		KEY_CASE(GLFW_KEY_P,					KEY_P)
		KEY_CASE(GLFW_KEY_Q,					KEY_Q)
		KEY_CASE(GLFW_KEY_R,					KEY_R)
		KEY_CASE(GLFW_KEY_S,					KEY_S)
		KEY_CASE(GLFW_KEY_T,					KEY_T)
		KEY_CASE(GLFW_KEY_U,					KEY_U)
		KEY_CASE(GLFW_KEY_V,					KEY_V)
		KEY_CASE(GLFW_KEY_W,					KEY_W)
		KEY_CASE(GLFW_KEY_X,					KEY_X)
		KEY_CASE(GLFW_KEY_Y,					KEY_Y)
		KEY_CASE(GLFW_KEY_Z,					KEY_Z)
		KEY_CASE(GLFW_KEY_LEFT_BRACKET,			KEY_LEFT_BRACKET)
		KEY_CASE(GLFW_KEY_BACKSLASH,			KEY_BACKSLASH)
		KEY_CASE(GLFW_KEY_RIGHT_BRACKET,		KEY_RIGHT_BRACKET)
		KEY_CASE(GLFW_KEY_GRAVE_ACCENT,			KEY_GRAVE_ACCENT)
		KEY_CASE(GLFW_KEY_WORLD_1,				KEY_WORLD_1)
		KEY_CASE(GLFW_KEY_WORLD_2,				KEY_WORLD_2)
		KEY_CASE(GLFW_KEY_ESCAPE,				KEY_ESCAPE)
		KEY_CASE(GLFW_KEY_ENTER,				KEY_ENTER)
		KEY_CASE(GLFW_KEY_TAB,					KEY_TAB)
		KEY_CASE(GLFW_KEY_BACKSPACE,			KEY_BACKSPACE)
		KEY_CASE(GLFW_KEY_INSERT,				KEY_INSERT)
		KEY_CASE(GLFW_KEY_DELETE,				KEY_DELETE)
		KEY_CASE(GLFW_KEY_RIGHT,				KEY_RIGHT)
		KEY_CASE(GLFW_KEY_LEFT,					KEY_LEFT)
		KEY_CASE(GLFW_KEY_DOWN,					KEY_DOWN)
		KEY_CASE(GLFW_KEY_UP,					KEY_UP)
		KEY_CASE(GLFW_KEY_PAGE_UP,				KEY_PAGE_UP)
		KEY_CASE(GLFW_KEY_PAGE_DOWN,			KEY_PAGE_DOWN)
		KEY_CASE(GLFW_KEY_HOME,					KEY_HOME)
		KEY_CASE(GLFW_KEY_END,					KEY_END)
		KEY_CASE(GLFW_KEY_CAPS_LOCK,			KEY_CAPS_LOCK)
		KEY_CASE(GLFW_KEY_SCROLL_LOCK,			KEY_SCROLL_LOCK)
		KEY_CASE(GLFW_KEY_NUM_LOCK,				KEY_NUM_LOCK)
		KEY_CASE(GLFW_KEY_PRINT_SCREEN,			KEY_PRINT_SCREEN)
		KEY_CASE(GLFW_KEY_PAUSE,				KEY_PAUSE)
		KEY_CASE(GLFW_KEY_F1,					KEY_F1)
		KEY_CASE(GLFW_KEY_F2,					KEY_F2)
		KEY_CASE(GLFW_KEY_F3,					KEY_F3)
		KEY_CASE(GLFW_KEY_F4,					KEY_F4)
		KEY_CASE(GLFW_KEY_F5,					KEY_F5)
		KEY_CASE(GLFW_KEY_F6,					KEY_F6)
		KEY_CASE(GLFW_KEY_F7,					KEY_F7)
		KEY_CASE(GLFW_KEY_F8,					KEY_F8)
		KEY_CASE(GLFW_KEY_F9,					KEY_F9)
		KEY_CASE(GLFW_KEY_F10,					KEY_F10)
		KEY_CASE(GLFW_KEY_F11,					KEY_F11)
		KEY_CASE(GLFW_KEY_F12,					KEY_F12)
		KEY_CASE(GLFW_KEY_F13,					KEY_F13)
		KEY_CASE(GLFW_KEY_F14,					KEY_F14)
		KEY_CASE(GLFW_KEY_F15,					KEY_F15)
		KEY_CASE(GLFW_KEY_F16,					KEY_F16)
		KEY_CASE(GLFW_KEY_F17,					KEY_F17)
		KEY_CASE(GLFW_KEY_F18,					KEY_F18)
		KEY_CASE(GLFW_KEY_F19,					KEY_F19)
		KEY_CASE(GLFW_KEY_F20,					KEY_F20)
		KEY_CASE(GLFW_KEY_F21,					KEY_F21)
		KEY_CASE(GLFW_KEY_F22,					KEY_F22)
		KEY_CASE(GLFW_KEY_F23,					KEY_F23)
		KEY_CASE(GLFW_KEY_F24,					KEY_F24)
		KEY_CASE(GLFW_KEY_F25,					KEY_F25)
		KEY_CASE(GLFW_KEY_KP_0,					KEY_KP_0)
		KEY_CASE(GLFW_KEY_KP_1,					KEY_KP_1)
		KEY_CASE(GLFW_KEY_KP_2,					KEY_KP_2)
		KEY_CASE(GLFW_KEY_KP_3,					KEY_KP_3)
		KEY_CASE(GLFW_KEY_KP_4,					KEY_KP_4)
		KEY_CASE(GLFW_KEY_KP_5,					KEY_KP_5)
		KEY_CASE(GLFW_KEY_KP_6,					KEY_KP_6)
		KEY_CASE(GLFW_KEY_KP_7,					KEY_KP_7)
		KEY_CASE(GLFW_KEY_KP_8,					KEY_KP_8)
		KEY_CASE(GLFW_KEY_KP_9,					KEY_KP_9)
		KEY_CASE(GLFW_KEY_KP_DECIMAL,			KEY_KP_DECIMAL)
		KEY_CASE(GLFW_KEY_KP_DIVIDE,			KEY_KP_DIVIDE)
		KEY_CASE(GLFW_KEY_KP_MULTIPLY,			KEY_KP_MULTIPLY)
		KEY_CASE(GLFW_KEY_KP_SUBTRACT,			KEY_KP_SUBTRACT)
		KEY_CASE(GLFW_KEY_KP_ADD,				KEY_KP_ADD)
		KEY_CASE(GLFW_KEY_KP_ENTER,				KEY_KP_ENTER)
		KEY_CASE(GLFW_KEY_KP_EQUAL,				KEY_KP_EQUAL)
		KEY_CASE(GLFW_KEY_LEFT_SHIFT,			KEY_LEFT_SHIFT)
		KEY_CASE(GLFW_KEY_LEFT_CONTROL,			KEY_LEFT_CONTROL)
		KEY_CASE(GLFW_KEY_LEFT_ALT,				KEY_LEFT_ALT)
		KEY_CASE(GLFW_KEY_LEFT_SUPER,			KEY_LEFT_SUPER)
		KEY_CASE(GLFW_KEY_RIGHT_SHIFT,			KEY_RIGHT_SHIFT)
		KEY_CASE(GLFW_KEY_RIGHT_CONTROL,		KEY_RIGHT_CONTROL)
		KEY_CASE(GLFW_KEY_RIGHT_ALT,			KEY_RIGHT_ALT)
		KEY_CASE(GLFW_KEY_RIGHT_SUPER,			KEY_RIGHT_SUPER)
		KEY_CASE(GLFW_KEY_MENU,					KEY_MENU)

		default: return KeyBoardType::KEY_UNKNOWN;
	}
}

#undef KEY_CASE

static void key_callback(GLFWwindow* window, int key, int scancode, int action, int mods)
{
	
	auto type = GLFWKeyBoardIDToKeyBoardType(key);
	auto& state = keyBoardButtonState.at(type);

	if (action == GLFW_PRESS)
	{
		if (state.isDown)
		{
			state.isDownPrevious = true;
		}
		state.isDown = true;
	}
	else
	{
		if (!state.isDown && state.isDownPrevious)
		{
			state.isDownPrevious = false;
		}
		state.isDown = false;
	}
	
}

void GlfwInput::Init()
{
	auto window = GlfwContext::Get().GetWindow();
	glfwSetCursorPosCallback(window, cursor_position_callback);
	glfwSetScrollCallback(window, scroll_callback);

	for(int i = 0; i <= (size_t)MouseButtonType::MOUSE_MAX; i++)
	{
		mouseButtonState.insert(std::make_pair((MouseButtonType)i, ButtonState()));
	}
	glfwSetMouseButtonCallback(window, mouse_button_callback);

	for (int i = 0; i <= (size_t)KeyBoardType::KEY_MAX; i++)
	{
		keyBoardButtonState.insert(std::make_pair((KeyBoardType)i, ButtonState()));
	}
	glfwSetKeyCallback(window, key_callback);

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

