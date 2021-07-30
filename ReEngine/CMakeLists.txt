cmake_minimum_required(VERSION 3.17)

project(Rengine)


message(STATUS "fetch re-make library")
include(FetchContent)
FetchContent_Declare(
  re-cmake
  GIT_REPOSITORY https://github.com/vgvgvvv/re-cmake
  GIT_TAG        "test-1.1"
)
FetchContent_MakeAvailable(re-cmake)


message(STATUS "re-cmake_SOURCE_DIR ${re-cmake_SOURCE_DIR}")
list(APPEND CMAKE_MODULE_PATH "${re-cmake_SOURCE_DIR}")
include(Init)

message(STATUS "project init git submodules")
ReMake_InitGit()
ReMake_UpdateSubModule()

ReMake_InitProject()

set(RENGINE_DOTNET_DIR "${CMAKE_CURRENT_LIST_DIR}/dotnet")
set(RENGINE_CONFIG_DIR "${CMAKE_CURRENT_LIST_DIR}/config")
set(RENGINE_BINARY_DIR "${CMAKE_CURRENT_LIST_DIR}/binary")
set(RENGINE_DOTNET_BINARY_DIR "${CMAKE_CURRENT_LIST_DIR}/binary/dotnet")
set(RENGINE_EXTERNAL_DIR "${CMAKE_CURRENT_LIST_DIR}/external")


ReMake_AddSubDirsRec(external)
ReMake_AddSubDirsRec(src)

find_package(ThirdPart)

message(STATUS "project Root ${PROJECT_SOURCE_DIR}")