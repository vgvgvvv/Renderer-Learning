
set(targetName ImGUILib)
ReMake_AddTArget(
	TARGET_NAME ${targetName}
	MODE SHARED
)

UseImGUIWithDock(${targetName} Glfw)