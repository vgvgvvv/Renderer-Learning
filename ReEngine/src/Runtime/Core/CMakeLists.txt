
set(linkLibs 
	ReOpenGL 
	CommonLib 
	RenderPipeline 
	DotNetLib
	EditorGUI
	ImGUILib)

set(targetName Core)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${linkLibs}
)


UseIniFile(${targetName})
