
message(STATUS "include OpenGL")

set(targetName ReOpenGL)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB opengl32 CommonLib RHI 3d-math
)

ReMake_StartUse()
UseGlew(${targetName})
USESTBIMAGE(${targetName})
ReMake_EndUse()