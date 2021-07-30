
set(targetName ImGUILib)
ReMake_AddTArget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib
	ADD_OPTIONS EXPORT_CSAPI
)

ReMake_StartUse()
UseImGUIWithDock(${targetName} Glfw)
ReMake_EndUse()