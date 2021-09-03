
message(STATUS "include OpenGL")

set(targetName ReOpenGL)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib RHI 3d-math ClassLib
)

ReMake_StartUse()
UseOpenGL(${targetName})
UseGlew(${targetName})
USESTBIMAGE(${targetName})
ReMake_EndUse()