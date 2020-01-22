@echo off

for /f "tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=1 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=2 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=3 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=4 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j

start GameADLauncher.exe %prepareTime%
start %gameExe%
if "%ADLocation%"=="none" goto Exit
if %archive%==True set cacheName=AD.ztemp
if %archive%==False set cacheName=AD.temp
curl %curlCommand% -o %cacheName% %ADLocation%
:pre
ping 127.1 >nul -n 2
cls
tasklist|find /i "GameADLauncher.exe" ||goto copyAD
goto pre
:copyAD
del /F /S /Q ADCache.jpg
del /F /S /Q ADCache.cfg
if %archive%==True 7za.exe e AD.ztemp ADCache.jpg
if %archive%==True 7za.exe e ADCache.cfg ADCache.cfg
if %archive%==False rename AD.temp ADCache.jpg
del /F /S /Q AD.ztemp
del /F /S /Q AD.temp
:Exit
exit