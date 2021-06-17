cmake_minimum_required(VERSION 3.17)

project(Rengine)

add_executable(Rengine)

include_directories(.)

target_sources(Rengine PRIVATE
		"Entrys/Windows.cpp"
		"Core/Build.h"
		"Core/Application.cpp"
		"Core/Application.h"
		"Platform/Windows/WindowsPlatformMisc.cpp"
		"Platform/Windows/WindowsPlatformMisc.h"
		"Platform/PlatformMisc.cpp"
		"Platform/PlatformMisc.h")

target_link_libraries(Rengine 
		"D3D12.lib" 
		"d3dcompiler.lib" 
		"dxgi.lib")