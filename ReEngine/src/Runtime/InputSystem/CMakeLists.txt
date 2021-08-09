
set(targetName InputSystem)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	Lib CommonLib 3d-math
)