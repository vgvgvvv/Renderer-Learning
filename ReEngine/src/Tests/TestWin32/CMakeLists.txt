
ReMake_ShowIncludeFileName()

set(TargetName TestWin32)
ReMake_AddTarget(TARGET_NAME ${TargetName} MODE EXE)

set_target_properties(${TargetName} PROPERTIES WIN32_EXECUTABLE TRUE)