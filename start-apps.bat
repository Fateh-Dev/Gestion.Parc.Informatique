@echo off

REM Change directory to the project folder
cd /d "%~dp0"

REM Change directory to the server folder and start the .NET 6 server
cd Server
start "" cmd /k dotnet watch run

REM Open a new Command Prompt window, change directory to the client folder, and start the Angular client
cd ../Client
start "" cmd /k ng serve --open
 
