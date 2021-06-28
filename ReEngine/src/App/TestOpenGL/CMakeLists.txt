message(STATUS "include TestOpenGL")

set(targetName TestOpenGL)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB ReOpenGL CommonLib RenderPipeline
)

UseImGUIWithDock(${targetName} Glfw)

