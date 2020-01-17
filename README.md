# ADLauncher by 琴梨梨  
## 说明  
该启动器可选择展示默认闪屏或动态拉取广告,且在广告拉取异常时显示默认闪屏  
DefaultSplash.jpg为默认闪屏,实际支持格式除jpg外也可用png等,但必须修改后缀为jpg  
ADCache.jpg为拉取的广告闪屏,如果该文件不是可加载图片或不存在则加载默认闪屏  
启动器需求.NET 4.7.2运行时,如果游戏上架steam可添加该运行时的depot  
闪屏比例为16:9,按比例作图,分辨率随意,但不建议低于800x450,如图片比例不是16:9会按比例自动缩放且周围留白  
  
## 使用方法  
打开Launch.bat,修改配置区内容并编译为Launch.exe  
设置游戏启动文件为Launch.exe  
  
## 文件说明  
7z.dll,7z.exe:7z库核心文件,用于在接收压缩后广告时解压  
DefaultSplash.jpg:默认闪屏,缺少会崩溃  
GameADLauncher.exe:闪屏窗口,基于.NET  
Launch.bat(编译后为Launch.exe):启动器主程序  
Timer.exe:延时结束闪屏窗口  
  
## 如何制作广告文件  
将广告图片导出为支持的格式  
如不开启压缩传输,那么图片文件直接就是广告文件了  
如开启压缩传输,需把图片命名为ADCache.jpg并压缩这个文件,压缩文件就是广告文件  

# 许可证  
7z.dll,7z.exe使用7z的许可证,请参考https://www.7-zip.org/license.txt  
本项目其余文件使用WTFPL,想干什么就干什么去吧,只要你别把自己电脑炸了就行   
