
ReMake_ShowIncludeFileName()

set(TargetName CommonLib)
ReMake_AddTarget(
	TARGET_NAME ${TargetName}
	MODE SHARED
	LIB_INTERFACE ReTemplate
)

ReMake_StartUse()
UseFmt(${TargetName})
UseSpdlog(${TargetName})
UseTinyDir(${TargetName})
UseIniFile(${TargetName})
UseFileDialog(${TargetName})
ReMake_EndUse()