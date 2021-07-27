
set(targetName ImGUILib)
ReMake_AddTArget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib
)

UseImGUIWithDock(${targetName} Glfw)