
set(linkLibs 
	CommonLib 
	RenderPipeline 
	DotNetLib
	Editor
	EditorGUI
	ImGUILib
	World
	GlobalAssets
	InputSystem
	GlfwWindow
	ClassLib)

set(targetName Core)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${linkLibs}
)

ReMake_StartUse()
UseGlew(${targetName})
USEGLFW(${targetName})
UseIniFile(${targetName})
ReMake_EndUse()