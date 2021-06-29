message(STATUS "include TestOpenGL")

set(targetName TestOpenGL)
set(linkLibs ReOpenGL CommonLib RenderPipeline DotNetLib)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB ${linkLibs}
)

UseImGUIWithDock(${targetName} Glfw)

