
message(STATUS "include World")

set(targetName World)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib 3d-math Serialization
)

ReMake_StartUse()
UseUUID(${targetName})
ReMake_EndUse()