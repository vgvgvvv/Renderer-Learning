
message(STATUS "include World")

set(targetName World)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
)