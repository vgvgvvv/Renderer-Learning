
set(targetName DotNetAPI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib Core
	ADD_OPTIONS EXPORT_CSAPI
)

ReMake_StartUse()
UseFileDialog(${targetName})
ReMake_EndUse()