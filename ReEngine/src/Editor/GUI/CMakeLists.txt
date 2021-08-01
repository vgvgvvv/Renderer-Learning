
set(libs 
	RenderPipeline 
	ImGUILib 
	ReOpenGL 
	RenderPipeline 
	GlobalAssets
	EditorContext
	CommonLib
	ClassLib)

set(targetName EditorGUI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${libs}
	ADD_OPTIONS EXPORT_CSAPI
)
