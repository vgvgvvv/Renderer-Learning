message(STATUS "include TestOpenGL")


ReMake_AddTarget(
	MODE EXE
	LIB ReOpenGL CommonLib
)

message(STATUS "TestOpenGL ReOpenGL_INCLUDE_DIR ${ReOpenGL_INCLUDE_DIR}")