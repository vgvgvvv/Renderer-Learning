
ReMake_ShowIncludeFileName()

set(TargetName CommonLib)
ReMake_AddTarget(
	TARGET_NAME ${TargetName}
	MODE STATIC
	LIB_INTERFACE ReTemplate
)

UseFmt(${TargetName})
UseSpdlog(${TargetName})
UseTinyDir(${TargetName})
UseIniFile(${TargetName})
