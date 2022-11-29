1. 关于项目配置数据库的详细步骤请参考同目录下 ***创建和配置数据库*** 文档介绍；
2. 关于项目配置数据源的详细步骤请参考同目录下 ***添加和配置数据源*** 文档介绍；
   
### 异常处理办法：
* CS0246	未能找到类型或命名空间名“WindowsFormsControlLibraryMadeByXJY”(是否缺少 using 指令或程序集引用?)
  
  * 处理办法：在可以打开的设计界面中，在 ***工具箱*** 窗口搜索 "**WatermarkTextBox**" 控件并将其拖动到设计界面上。稍等片刻，IDE便会正确找到引用了。

    ![GIF1](%E6%9C%AA%E6%89%BE%E5%88%B0%E5%BC%95%E7%94%A8%E8%A7%A3%E5%86%B3%E5%8A%9E%E6%B3%95.gif)

* System.Data.SqlClient.SqlException:“An attempt to attach an auto-named database for file C:\Users\xjy\Downloads\UserLoginFramework-master\bin\Debug\DAL\DataBase\UserDatabase.mdf failed. A database with the same name exists, or specified file cannot be opened, or it is located on UNC share.”

    * 处理办法：请参考同目录下 ***添加和配置数据源.md*** ==> ***三、其他事项*** 的第3点。
    ![图1](%E6%95%B0%E6%8D%AE%E5%BA%93%E8%BF%9E%E6%8E%A5%E5%BC%82%E5%B8%B8.png)