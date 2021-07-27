
set(libs 
	RenderPipeline 
	ImGUILib 
	ReOpenGL 
	RenderPipeline 
	GlobalAssets
	Editor)

set(targetName EditorGUI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${libs}
)
