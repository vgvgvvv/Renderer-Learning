
set(targetName OpenGLTestPlatform)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB CommonLib ReOpenGL TestOpenGL
)
