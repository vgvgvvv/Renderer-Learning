
message(STATUS "include OpenGL")

set(targetName ReOpenGL)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE STATIC
	LIB opengl32 CommonLib
)

USEGLAD(${targetName})
USEGLFW(${targetName})
USESTBIMAGE(${targetName})