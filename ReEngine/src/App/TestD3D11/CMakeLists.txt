

set(d3d_libs
        d3d11.lib
        dxgi.lib
        dxguid.lib
        D3DCompiler.lib
        winmm.lib)


set(targetName TestD3D11)
ReMake_AddTarget(
        TARGET_NAME ${targetName}
        MODE EXE
        LIB ${d3d_libs}
)

set_target_properties(${targetName} PROPERTIES WIN32_EXECUTABLE TRUE)