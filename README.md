# ADLauncher by 琴梨梨 

## 说明  
该启动器可选择展示默认闪屏或动态拉取广告,且在广告拉取异常时显示默认闪屏  
DefaultSplash.jpg为默认闪屏,实际支持格式除jpg外也可用png等,但必须修改后缀为jpg  
ADCache.jpg为拉取的广告闪屏,如果该文件不是可加载图片或不存在则加载默认闪屏  
ADCache.json为拉取的广告配置文件，仅拉取压缩文件开启时可用  
Launcher.ico为闪屏的图标,如果没有则使用默认.NET图标  
把更新程序命名为Patch.exe放在游戏目录下,启动时也会自动安装更新  
启动器需求.NET 4.7.2运行时,如果游戏上架steam可添加该运行时的depot  
闪屏比例为16:9,按比例作图,分辨率随意,但不建议低于800x450,如图片比例不是16:9会按比例自动缩放且周围留白  
  
## 使用方法  
请参考[部署文档][]  

  
## 文件说明  
7za.exe:7z库核心文件,用于在接收压缩后广告时解压,如果你没有使用压缩广告,你可以删掉它  
GameADLauncher.exe:闪屏窗口,基于.NET  
Launch.exe:启动器主程序  
Launch.cfg:参数文件  
LitJson.dll:Json核心库   
  
## 如何制作广告文件  
将广告图片导出为支持的格式  
如不开启压缩传输,那么图片文件直接就是广告文件了  
如开启压缩传输,需把图片命名为ADCache.jpg，把配置文件命名为ADCache.json（可选）并压缩这两个文件,压缩文件就是广告文件  
### 配置文件  
配置文件为json格式,请参考下面的样式  
`
{  
    "ADURL": "广告地址,支持steam://等任意可以拉起的scheme",  
    "clickToExit": "True或False,True时点击广告后启动器退出,False则点击广告后启动器继续显示等待延时后退出",  
    "needUpdate": "True或False,True时会下载更新,False时忽略更新",  
    "updateURL": "更新下载地址,仅支持http/https/ftp"  
}  
`
# 许可证  
7za.exe使用7z的许可证,请参考https://www.7-zip.org/license.txt  
本项目其余文件使用WTFPL,想干什么就干什么去吧,只要你别把自己电脑炸了就行  
琴梨梨不对本项目使用中可能产生的包括但不限于系统蓝绿屏,数据丢失,程序崩溃等任何损失负责  


[部署文档]:deploy.md
