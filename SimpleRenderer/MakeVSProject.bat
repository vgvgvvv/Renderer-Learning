call AnotherBuildSystem.exe

mkdir Temp\VS2019
cd Temp\VS2019

cmake -G "Visual Studio 16 2019" ../../Source 

pause