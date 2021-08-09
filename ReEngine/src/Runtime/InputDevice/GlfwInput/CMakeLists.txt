
set(targetName GlfwInput)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB 3d-math
)

ReMake_StartUse()
USEGLFW(${targetName})
ReMake_EndUse()