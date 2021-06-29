
ReMake_ShowIncludeFileName()

set(TargetName CommonLib)
ReMake_AddTarget(
	TARGET_NAME ${TargetName}
	MODE STATIC
	LIB_INTERFACE ReTemplate
	PCH_PUBLIC Common.h
)

UseFmt(${TargetName})
UseSpdlog(${TargetName})
UseTinyDir(${TargetName})
