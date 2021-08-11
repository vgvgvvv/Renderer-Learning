
set(targetName GlfwWindow)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB 3d-math CommonLib ReOpenGL InputSystem GenericWindow ImGUILib
)

ReMake_StartUse()
UseGlew(${targetName})
UseGlfw(${targetName})
UseIniFile(${targetName})
ReMake_EndUse()