
set(targetName ImGUILib)
ReMake_AddTArget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib
)

ReMake_StartUse()
UseImGUIWithDock(${targetName} Glfw)
ReMake_EndUse()