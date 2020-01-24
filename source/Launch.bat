
for /f "tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=1 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=2 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=3 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j
for /f "skip=4 tokens=1-2 delims==" %%i in (Launch.cfg) do set %%i=%%j

if exist  Patch.exe goto prepareForPatch
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
del /F /S /Q PatchTemp.bat
del /F /S /Q ADCache.jpg
del /F /S /Q ADCache.json
if %archive%==True 7za.exe e AD.ztemp ADCache.jpg
if %archive%==True 7za.exe e AD.ztemp ADCache.json
if %archive%==False rename AD.temp ADCache.jpg
del /F /S /Q AD.ztemp
del /F /S /Q AD.temp
:Exit
exit



:prepareForPatch
del /F /S /Q PatchTemp.bat
set /p="@echo of"<nul>>PatchTemp.bat
echo f >>PatchTemp.bat
set /p="echo Installing Update"<nul>>PatchTemp.bat
echo ... >>PatchTemp.bat
set /p="title Installing Update"<nul>>PatchTemp.bat
echo ... >>PatchTemp.bat
set /p="Patch.ex"<nul>>PatchTemp.bat
echo e >>PatchTemp.bat
set /p=":pr"<nul>>PatchTemp.bat
echo e >>PatchTemp.bat
set /p="ping 127.1 >nul -n "<nul>>PatchTemp.bat
echo 2 >>PatchTemp.bat
set /p="tasklist|find /i "Patch.exe" ||goto clea"<nul>>PatchTemp.bat
echo n >>PatchTemp.bat
set /p="goto pr" <nul>>PatchTemp.bat
echo e >>PatchTemp.bat
set /p=":clea" <nul>>PatchTemp.bat
echo n >>PatchTemp.bat
set /p="del /F /S /Q Patch.ex"<nul>>PatchTemp.bat
echo e >>PatchTemp.bat
set /p="del /F /S /Q ADCache.jp"<nul>>PatchTemp.bat
echo g >>PatchTemp.bat
set /p="del /F /S /Q ADCache.jso"<nul>>PatchTemp.bat
echo n >>PatchTemp.bat
set /p="start Launch.ex"<nul>>PatchTemp.bat
echo e >>PatchTemp.bat
set /p="exi"<nul>>PatchTemp.bat
echo t >>PatchTemp.bat
start PatchTemp.bat
exit