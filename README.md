怎样在GitHub上传自己的项目（最新）
https://zhenhong.blog.csdn.net/article/details/118487040?spm=1001.2101.3001.6650.1&utm_medium=distribute.pc_relevant.none-task-blog-2%7Edefault%7ECTRLIST%7ERate-1-118487040-blog-125073051.235%5Ev43%5Econtrol&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2%7Edefault%7ECTRLIST%7ERate-1-118487040-blog-125073051.235%5Ev43%5Econtrol&utm_relevant_index=2

手把手教学-github上传文件及图片
https://zhuanlan.zhihu.com/p/54924115

学习视频
https://www.sikiedu.com/my/course/74

编辑器脚本
New Unity Project/Assets/Editor/CreatAssetBundles.cs

读取AB包脚本：
New Unity Project/Assets/Scripts
从本地加载AB包LoadFromFileExample.cs 
从网络加载AB包LoadFromWebExample.cs 

阿里云部署AB包
https://account.aliyun.com/login/login.htm?oauth_callback=https://oss.console.aliyun.com/index

注意打包和依赖，以及代码加载时的先后顺序

打包压缩LZMA（流的形式加载，压缩体积小，但要求完全加载）和LZ4（块的形式加载，压缩体积偏大，但是不要求完全加载）
