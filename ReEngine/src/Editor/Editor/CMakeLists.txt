
set(libs 
	CommonLib
	ReTemplate
	World
	EditorContext
	EditorGUI)


set(targetName Editor)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ${libs}
)