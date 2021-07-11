cd %~dp0
NativeAPIExporter.exe dir=.. config=native_config.json

robocopy temp/Output/ ../dotnet/DotNetDriver/DotNetDriver/Export/ *.cs