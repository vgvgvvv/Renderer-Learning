
set(linkLibs 
	ReOpenGL 
	CommonLib 
	RenderPipeline 
	DotNetLib
	EditorGUI
	ImGUILib
	World
	Assets)

set(targetName Core)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${linkLibs}
)

UseGlew(${targetName})
USEGLFW(${targetName})
UseIniFile(${targetName})
