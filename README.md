# 要求

* [Visual Studio Community 2022](https://visualstudio.microsoft.com/zh-hans/) - 17.4.1 及以上
* [Microsoft .NET Framework](https://learn.microsoft.com/zh-cn/dotnet/framework/get-started/overview) 4.8.04084 及以上
* 「[.NET 桌面开发](https://learn.microsoft.com/zh-cn/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)」工作负载
* 「[数据存储和处理](https://learn.microsoft.com/zh-cn/visualstudio/install/workload-component-id-vs-community?view=vs-2022&preserve-view=true#data-storage-and-processing)」工作负载
* [SQL Server Data Tools](https://learn.microsoft.com/zh-cn/sql/ssdt/download-sql-server-data-tools-ssdt?view=sql-server-ver16) - 17.0.62207.28050 及以上

> [如何修改 Visual Studio 工作负载？](https://learn.microsoft.com/zh-cn/visualstudio/install/modify-visual-studio?view=vs-2022)

# 文档

1. 关于项目配置数据库的详细步骤请参考 ***[创建和配置数据库](./image/%E5%88%9B%E5%BB%BA%E5%92%8C%E9%85%8D%E7%BD%AE%E6%95%B0%E6%8D%AE%E5%BA%93.md)*** 文档介绍；
2. 关于项目配置数据源的详细步骤请参考 ***[添加和配置数据源](./image/%E6%B7%BB%E5%8A%A0%E5%92%8C%E9%85%8D%E7%BD%AE%E6%95%B0%E6%8D%AE%E6%BA%90.md)*** 文档介绍；
3. 本 Demo 默认的用户名和登陆密码均为 `admin`；
   
### 可能出现的异常及相应处理办法：
* CS0246	未能找到类型或命名空间名“WindowsFormsControlLibraryMadeByXJY”(是否缺少 using 指令或程序集引用?)

  * “WindowsFormsControlLibraryMadeByXJY”是笔者创建的[用户自定义控件库](https://blog.csdn.net/YMGogre/article/details/126508042)，本 Demo 中用到了控件库中的“**水印文本框**”控件，所以需要引用该控件库。
  
  * 处理办法：在可以打开的设计界面中，在 <font color="#B31623">***工具箱***</font> 窗口搜索 "**WatermarkTextBox**" 控件并将其拖动到设计界面上。稍等片刻，IDE便会正确找到引用了。

    > 💬 <font color="#B31623">***“工具箱”***</font>停靠窗口没有 "**WatermarkTextBox**" 控件？请参阅[这篇博客](https://blog.csdn.net/YMGogre/article/details/128092649)。

    ![GIF1](./image/%E6%9C%AA%E6%89%BE%E5%88%B0%E5%BC%95%E7%94%A8%E8%A7%A3%E5%86%B3%E5%8A%9E%E6%B3%95.gif)

    > 🔔 如果您想使用已经正常引用了该控件库且能够直接运行的 Demo，请前往 [CSDN](https://download.csdn.net/download/YMGogre/87202891) 下载本 Demo！
    
  > 📌 最新的源码已经解决了该问题

* System.Data.SqlClient.SqlException:“An attempt to attach an auto-named database for file C:\Users\xjy\Downloads\UserLoginFramework-master\bin\Debug\DAL\DataBase\UserDatabase.mdf failed. A database with the same name exists, or specified file cannot be opened, or it is located on UNC share.”

    * 处理办法：请参考 ***[添加和配置数据源.md](./image/%E6%B7%BB%E5%8A%A0%E5%92%8C%E9%85%8D%E7%BD%AE%E6%95%B0%E6%8D%AE%E6%BA%90.md)*** ==> ***三、其他事项*** 的第3点。
    ![图1](./image/%E6%95%B0%E6%8D%AE%E5%BA%93%E8%BF%9E%E6%8E%A5%E5%BC%82%E5%B8%B8.png)

    > 📌 最新的源码已经解决了该问题