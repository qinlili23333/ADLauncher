@echo off

rem 修改这里的参数后编译为exe即可
rem 游戏可执行文件,不在一个目录下需要输入相对路径
set gameExe=Game.exe
rem 广告拉取地址,防止劫持建议使用https,不显示广告输入none即可
set ADLocation=https://redirect.qinlili.bid/test/AD.jpg
rem 广告拉取格式,压缩包格式输入True,图片格式输入False,推荐使用压缩包格式节约CDN流量
set archive=False
rem 广告拉取附加指令,默认留空,广告使用curl拉取,如果服务器有特殊要求请在这里附带,参考curl --help
set curlCommand=
rem 游戏启动预留时间,指点击游戏exe到游戏窗体出现需要的时间,可多预留,但少预留影响体验
set prepareTime=6


rem 启动闪屏
start GameADLauncher.exe
rem 先启动游戏,不影响游戏启动速度
start %gameExe%

rem 召唤定时器延时杀死闪屏窗口
start Timer.exe %prepareTime%

rem 异步更新广告内容,关闭广告则跳过
if "%ADLocation%"=="none" goto Exit
if %archive%==True set cacheName=AD.ztemp
if %archive%==False set cacheName=AD.temp
curl %curlCommand% -o %cacheName% %ADLocation%

rem 等待闪屏退出后更新广告资源
:pre
ping 127.1 >nul -n 2
cls
tasklist|find /i "GameADLauncher.exe" ||goto copyAD
goto pre

rem 更新广告资源
:copyAD
del /F /S /Q ADCache.jpg
if %archive%==True 7z.exe e AD.ztemp ADCache.jpg
if %archive%==False rename AD.temp ADCache.jpg
rem 删除缓存
del /F /S /Q AD.ztemp
del /F /S /Q AD.temp

rem 退出启动器
:Exit
exit

