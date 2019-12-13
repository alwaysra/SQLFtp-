# SQLFtp-
## SQLFtp是一款数据备份工具。

## SQLFtp主要为用户提供每天几点几分或者每间隔时间备份 并上传到FTP服务器
### 支持数据库：
### Microsoft 2000|Microsoft 2005|Microsoft2008 R2以及未来版本
工具做的步骤就像把大象放进冰箱一样只需要三步：
1.  依次选择需要备份的数据库并执行备份到软件安装目录下
2. 使用RAR压缩刚刚备份的备份文件
3. 将压缩的文件使用FTP协议上传到FTP服务器

### Q1：如何安装并使用？
1.  首先应该安装在数据库所在的Windows服务器中
2. 得到数据库用户名和密码最好是*sa*的密码 因为*sa*拥有最高权限
3. 在Internet上获取或者自行搭建*FTP*服务器并得到授权账户与密码
为了简单可以使用匿名用户*anonymous*默认密码为空
4. 输入数据库IP如果是本机可以用*127.0.0.1*或者小数点（*.*）来代表本机
5. 点**账套**下拉框选择需要备份的数据库
6. 点击**添加账套**将账套添加到右边的列表框中
7. 设置备份的方式可以是每天X点X分或者是每间隔X小时X分钟
8. 输入FTP服务器地址，用户名和密码
9. 点击**立即执行**可以测试工具是否正常

### Q2：这个工具是免费的吗？
1. 这个工具是相对免费的具体以未来发布为准
2. 这里我将不定期发布授权码

### Q3：我如何使用授权码或者更新授权码？
1. 打开工具安装目录 找到SQLFtp备份.exe.Config文件以记事本方式打开
2. 修改或者删除这一行 <add key="Key" value="" />
3. 然后重启工具将要求输入新的授权码

### 2019-12-13更新授权码
### C4A5DF531B1276306DDBDF2F3107F190E3EF166842D75B5B8AA84A2E8779116C
### 可以使用到2020-3-11

### 我的E-mail
[珏氏春秋](mailto:alwaysra@163.com)
