
ReMake_ShowIncludeFileName()

set(TargetName CommonLib)
ReMake_AddTarget(
	TARGET_NAME ${TargetName}
	MODE STATIC
)

UseFmt(${TargetName})
UseSpdlog(${TargetName})

