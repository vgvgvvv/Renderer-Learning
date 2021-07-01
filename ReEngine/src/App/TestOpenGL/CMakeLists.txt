message(STATUS "include TestOpenGL")

set(targetName TestOpenGL)
set(linkLibs ReOpenGL CommonLib RenderPipeline DotNetLib)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${linkLibs}
)

UseImGUIWithDock(${targetName} Glfw)
UseIniFile(${targetName})
