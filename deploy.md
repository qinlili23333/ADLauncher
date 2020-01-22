# 部署到游戏  
## 0. clone 本项目到本地  
## 1. 创建游戏默认闪屏  
游戏默认闪屏建议为`16:9`比例否则会被缩放而出现白边.建议分辨率大于`800x450`.  
支持`jpg/png`等格式.  
保存为`DefaultSplash.jpg`放在项目路径内.  
## 2. 创建启动器 icon (可选)  
将启动器 icon 保存为`Launcher.ico`放在项目路径内.  
## 3. 制作并部署广告(无广告则跳过)  
在服务器上部署广告服务.广告资源以`http/https`请求,每次请求返回一个广告文件(请参考 README 制作广告文件) .同时支持静态资源部署和动态返回.    
## 4. 使用文本编辑器修改`Launch.cfg`  
#### gameExe=  
输入游戏的可执行文件名称,如`Game.exe`  
#### ADLocation=  
输入请求广告的`url`,该`url`在浏览器内打开应返回一个广告文件(请参考 README 制作广告文件)  
琴梨梨提供的测试地址:
非压缩https://redirect.qinlili.bid/test/AD.jpg  
压缩无链接https://redirect.qinlili.bid/test/AD.7z  
压缩有链接https://redirect.qinlili.bid/test/AD.tar.bz2  
#### archive=  
广告文件是否压缩,压缩填写`True`,非压缩填写`False`  
#### curlCommand=  
广告文件使用`curl`获取,你可以在这里附加额外的`curl`命令,具体可在命令行内输入`curl --help`查看    
#### prepareTime=  
游戏启动预留时间,建议多留一点时间,单位为毫秒(自1.0.2版本开始).超过该时间后闪屏会消失
## 5. 拷贝下列文件到游戏目录下,设置游戏启动文件为`Launch.exe`  
7za.exe  
DefaultSplash.jpg  
Launcher.ico  (可选)
GameADLauncher.exe  
Launch.exe  
Launch.cfg  
## 6. 部署完成!你可以正常发布游戏了!  
