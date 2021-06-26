
message(STATUS "include OpenGL")

message(STATUS "ReOpenGL CMAKE_CURRENT_LIST_DIR ${CMAKE_CURRENT_LIST_DIR}")
message(STATUS "ReOpenGL PROJECT_SOURCE_DIR ${PROJECT_SOURCE_DIR}")

file(RELATIVE_PATH rel_src ${PROJECT_SOURCE_DIR} ${CMAKE_CURRENT_LIST_DIR})
message(STATUS "ReOpenGL RELATIVE_PATH ${rel_src}")

set(ReOpenGL_INCLUDE_DIR ${rel_src} PARENT_SCOPE)

set(targetName ReOpenGL)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE STATIC
	LIB opengl32 CommonLib
)

USEGLAD(${targetName})
USEGLEW(${targetName})
USEGLFW(${targetName})