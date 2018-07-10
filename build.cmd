@echo off
setlocal

set _config=%1
if not defined _config (
  set _config=Debug
)

echo --------------------------
echo !!! Restoring packages !!!
echo --------------------------
dotnet restore

echo -------------------------
echo !!! Cleaning solution !!!
echo -------------------------
dotnet clean -c %_config%

echo -------------------------
echo !!! Building solution !!!
echo -------------------------
dotnet build -c %_config%

endlocal
@echo on