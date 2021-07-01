set from=../DotNetDriver/bin/Debug/netcoreapp3.1/
set to=../../../binary/dotnet
robocopy /S %from% %to% 
if ErrorLevel 8 (exit /B 1) else (exit /B 0)