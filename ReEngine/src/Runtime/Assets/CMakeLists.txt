

set(targetName Assets)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	Lib RHI CommonLib
)

UseSpdlog(${targetName})
UseUuid(${targetName})