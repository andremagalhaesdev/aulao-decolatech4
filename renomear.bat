@echo off
cd "C:\Users\André Magalhães\Desktop\PROJETOS]PROETOS C# (.NET)\aulao-decolatech4"

for /D %%i in ("*") do (
    cd "%%i"
    dotnet new console -n "projeto"
    cd ..
)