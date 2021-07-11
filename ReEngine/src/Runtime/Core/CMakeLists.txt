
set(linkLibs 
	ReOpenGL 
	CommonLib 
	RenderPipeline 
	DotNetLib
	EditorGUI)

set(targetName Core)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${linkLibs}
)


UseImGUIWithDock(${targetName} Glfw)
UseIniFile(${targetName})
