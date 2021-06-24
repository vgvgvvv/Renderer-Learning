cmake_minimum_required(VERSION 3.17)

project(Rengine)

list(APPEND CMAKE_MODULE_PATH "${PROJECT_SOURCE_DIR}/cmake")
include(Init)

ReMake_InitProject()

ReMake_AddSubDirsRec(src)

message(STATUS "project Root ${PROJECT_SOURCE_DIR}")