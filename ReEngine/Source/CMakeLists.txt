cmake_minimum_required(VERSION 3.17)

project(Rengine)

add_executable(Rengine)

target_sources(Rengine PRIVATE Entrys/Windows.cpp "Core/Application.cpp" "Core/Application.h")
target_link_libraries(Rengine 
		"D3D12.lib" 
		"d3dcompiler.lib" 
		"dxgi.lib")