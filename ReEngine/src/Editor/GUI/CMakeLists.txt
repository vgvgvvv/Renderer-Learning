

set(targetName EditorGUI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB RenderPipeline ImGUILib ReOpenGL RenderPipeline Assets
)
