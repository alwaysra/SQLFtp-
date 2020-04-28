using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Common.Utility;
using System.IO;
using System.Configuration;
using Microsoft.VisualBasic;
using EnPass;
using System.Net.Sockets;
using System.Net;

namespace SQLFtp备份
{
    public partial class Form1 : Form
    {
        private string enddate;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string enddate)
        {
            InitializeComponent();
            this.enddate = enddate;
            this.Text += " --- "+enddate;
        }

        string filenameed = "";

        //初始化E(Initialization)
        private void Initialization()
        {
            //读取数据库区域
            tb_sqlserver.Text = ConfigGetValue("SQLServer") != "" ? ConfigGetValue("SQLServer") : ".";
            tb_sqlname.Text = ConfigGetValue("SQLUser") != "" ? ConfigGetValue("SQLUser") : "sa";
            string sqlpwd = ConfigGetValue("SQLPwd");
            if (sqlpwd != "")
            {
                tb_sqlpwd.Text = EnPassword.EnPasswordJJ(sqlpwd, 12138, false);
            }
            else { tb_sqlpwd.Text = ""; }
            string dbnamestr = ConfigGetValue("Dbnames");
            lb_db.Items.Clear();
            if (dbnamestr != "")
            {
                string[] dbnames = dbnamestr.Split(',');
                foreach (var item in dbnames)
                {
                    if (item != "") { lb_db.Items.Add(item); }
                }
            }
            //读取定时区域
            if (ConfigGetValue("TimType") == "0")
            {
                rb_day.Checked = true;
                numericUpDown1.Value = Convert.ToDecimal(ConfigGetValue("TimH"));
                numericUpDown2.Value = Convert.ToDecimal(ConfigGetValue("TimM"));
            }
            else if (ConfigGetValue("TimType") == "1")
            {
                rb_jg.Checked = true;
                numericUpDown3.Value = Convert.ToDecimal(ConfigGetValue("TimH"));
                numericUpDown4.Value = Convert.ToDecimal(ConfigGetValue("TimM"));
            }
            //读取FTP区域
            tb_ftpserver.Text = ConfigGetValue("FtpS") != "" ? ConfigGetValue("FtpS") : "127.0.0.1";
            tb_ftpport.Text = ConfigGetValue("FtpPort") != "" ? ConfigGetValue("FtpPort") : "21";
            tb_ftpuser.Text = ConfigGetValue("FtpUser") != "" ? ConfigGetValue("FtpUser") : "anonymous";
            string ftppwd = ConfigGetValue("FtpPwd");
            if (ftppwd != "")
            {
                tb_ftppwd.Text = EnPassword.EnPasswordJJ(ftppwd, 12138, false);
            }
            else { tb_ftppwd.Text = ""; }
            //读取完毕之后测试FTP连接
            //如果成功则点了 启动
            FTPHelper ftp = new FTPHelper(tb_ftpserver.Text + ":" + tb_ftpport.Text, "/", tb_ftpuser.Text, tb_ftppwd.Text);
            try
            {
                //ftp.GetFilesDetailList();
                //ftp.GetFileList("");
                bt_start.PerformClick();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                tb_re.Text = ex.Message.ToString();
            }
        }

        /// <summary>  
        /// 写入值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <param name="value"></param>  
        public static void ConfigSetValue(string key, string value)
        {
            //增加的内容写在appSettings段下 <add key="RegCode" value="0"/>  
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件   
        }

        /// <summary>  
        /// 读取指定key的值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <returns></returns>  
        public static string ConfigGetValue(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_db.Items.Count != 0)
            {
                if (lb_db.SelectedIndex != -1)
                {
                    lb_db.Items.RemoveAt(lb_db.SelectedIndex);
                }
                else { MessageBox.Show("未选择任何账套"); }
            }
            else
            {
                MessageBox.Show("不存在任何账套");
            }
        }

        private void cb_data_DropDown(object sender, EventArgs e)
        {
            //将弹出下拉菜单
            cb_data.Items.Clear();
            //1.声明数据库连接字符串
            string constr = "Server=" + tb_sqlserver.Text + ";user=" + tb_sqlname.Text + ";pwd=" + tb_sqlpwd.Text + ";database=master";
            //2.创建数据库连接对象
            SqlConnection sqlCon = new SqlConnection(constr);
            //3.打开数据库连接
            try
            {
                sqlCon.Open();
                string sql = "SELECT * FROM sysdatabases";
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader datar = sqlCmd.ExecuteReader();

                while (datar.Read())
                {
                    cb_data.Items.Add(datar["name"]);
                }
            }
            catch (Exception ex)
            {
                //tb_sqlre.AppendText(ex.Message.ToString() + "\n");
                MessageBox.Show(ex.Message.ToString(), "连接数据库错误");
            }
            finally
            {
                //7.关闭数据库连接
                sqlCon.Close();
            }
        }

        private void bt_adddb_Click(object sender, EventArgs e)
        {
            if (cb_data.SelectedIndex != -1)
            {
                if (cb_data.SelectedItem.ToString() != "")
                {
                    String addname = cb_data.SelectedItem.ToString();
                    if (!lb_db.Items.Contains(addname))
                    {
                        lb_db.Items.Add(cb_data.SelectedItem.ToString());
                    }
                    else { MessageBox.Show("已经添加该数据库"); }
                }
            }
            else { MessageBox.Show("不存在任何名称"); }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_ftpuser.Text = "anonymous";
                tb_ftpuser.ReadOnly = true;
                tb_ftppwd.Text = "";
                tb_ftppwd.ReadOnly = true;
            }
            else {
                tb_ftpuser.Text = "anonymous";
                tb_ftpuser.ReadOnly = false;
                tb_ftppwd.Text = "";
                tb_ftppwd.ReadOnly = false;
            }
        }

        private void bt_ftptext_Click(object sender, EventArgs e)
        {

            FTPHelper ftp = new FTPHelper(tb_ftpserver.Text + ":" + tb_ftpport.Text, "/", tb_ftpuser.Text, tb_ftppwd.Text);
            try
            {
                ftp.GetFilesDetailList();
                tb_re.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss 【测试成功】\r\n");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                tb_re.Text = ex.Message.ToString();
            }

        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            //1.检查数据库列表是否有数据库
            if (lb_db.Items.Count == 0) {
                MessageBox.Show("至少选择一个数据库账套");
                return;
            }
            //2.检查定时设置是否有效
            if (rb_day.Checked == false && rb_jg.Checked == false) {
                MessageBox.Show("至少选择一种定时设置");
                return;
            }
            //3.假如是间隔时间模式 小时为0分钟就应该是1分钟
            if (rb_jg.Checked)
            {
                if (numericUpDown3.Value == 0)
                {
                    numericUpDown4.Value = 1;
                }
            }
            //4.如果是间隔模式 则计算倒计时
            if (rb_jg.Checked)
            {
                if (numericUpDown3.Value == 0)
                {
                    numericUpDown4.Value = 1;
                }
                //计算倒计时
                int djs_s = Convert.ToInt32(numericUpDown3.Value) * 60 * 60 + Convert.ToInt32(numericUpDown4.Value) * 60;
                //djs_s = 3;//调试模式强行改为3秒后
                tb_djs.Text = djs_s.ToString();
            }
            //5.如果已经是进入时间模式则停止
            if (timer1.Enabled) {
                timer1.Enabled = false;
                bt_start.Text = "启动";
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            else
            {
                bt_savecon_Click(sender, e);
                bt_start.Text = "停止";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                timer1.Interval = 1000;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rb_day.Checked) {
                string h = DateTime.Now.Hour.ToString();
                string m = DateTime.Now.Minute.ToString();
                string s = DateTime.Now.Second.ToString();
                Debug.WriteLine("h和m:" + h + ":" + m + ":" + s);
                if (numericUpDown1.Value.ToString() == h && numericUpDown2.Value.ToString() == m && s == "0") {
                    timer1.Enabled = false;
                    checkingKey();

                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                }
            }
            if (rb_jg.Checked) {
                if (tb_djs.Text != "0")
                {
                    tb_djs.Text = (int.Parse(tb_djs.Text) - 1).ToString();
                }
                else
                {
                    timer1.Enabled = false;
                    checkingKey();
                    //计算倒计时
                    int djs_s = Convert.ToInt32(numericUpDown3.Value) * 60 * 60 + Convert.ToInt32(numericUpDown4.Value) * 60;
                    //djs_s = 3;//调试模式强行改为3秒后
                    tb_djs.Text = djs_s.ToString();
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                }
            }
        }
        /// <summary>
        /// 验证授权码
        /// </summary>
        private void checkingKey() {
            string _key = ConfigGetValue("Key");
            if (_key != "") {
                enddate = EnPassword.CheckEnPassword2("RaSQLFtp", _key, 365);
                if (enddate!="19700101") {
                    ftp_upfiles();
                }
                else
                {
                    MessageBox.Show("授权码无效或已过期!");
                }
            }
            else
            {
                MessageBox.Show("无授权码");
            }
        }
        /// <summary>
        /// SQL执行数据库备份 返回真成功 返回假失败
        /// </summary>
        /// <param name="bfdb"></param>
        /// <param name="bfpath"></param>
        /// <param name="bffilename"></param>
        /// <returns></returns>
        private bool sql_backupdatabase(string constr, string bfdb, string bfpath, object bffilename)
        {
            //2.创建数据库连接对象
            SqlConnection sqlCon = new SqlConnection(constr);
            //3.打开数据库连接
            try
            {
                sqlCon.Open();
                sqlCon.InfoMessage += new SqlInfoMessageEventHandler(DataRepair);
                string sql = "BACKUP DATABASE " + bfdb + " TO DISK='" + bfpath + bffilename + "'";
                Debug.WriteLine("bfsql:" + sql);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //tb_sqlre.AppendText(ex.Message.ToString() + "\n");
                MessageBox.Show(ex.Message.ToString(), "连接数据库错误");
                return false;
            }
            finally
            {
                //7.关闭数据库连接
                sqlCon.Close();
            }
        }
        /// <summary>
        /// 使用RAR压缩文件
        /// </summary>
        /// <param name="rarfilename">压缩文件名</param>
        /// <param name="filename">待压缩文件名</param>
        private void rarfile(string rarfilename, string filename) {
            //Process.Start("rar.exe", " a -df -ep -k " + rarfilename + filename);
            Process p = new Process();
            p.StartInfo.FileName = "rar.exe";
            Debug.WriteLine("rarfile参数: a -df -ep -k " + rarfilename + " " + filename);
            p.StartInfo.Arguments = " a -df -ep -k " + rarfilename + " " + filename;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();
        }

        private void DataRepair(object sender, SqlInfoMessageEventArgs e)
        {
            tb_re.Text += (e.Message + "\r\n");
        }

        private void SqlCon_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkingKey();
        }
        /// <summary>
        /// FTP上传文件
        /// </summary>
        /// <param name="ftpserver">FTP地址</param>
        /// <param name="ftpuser">FTP用户名</param>
        /// <param name="ftppwd">FTP密码</param>
        /// <param name="dbname">创建的文件夹名称</param>
        /// <param name="filename">待上传文件名</param>
        private void ftp_fileup(string ftpserver, string ftpuser, string ftppwd, string dbname, string filename) {
            FTPHelper ftp = new FTPHelper(ftpserver, "/", ftpuser, ftppwd);
            ftp.MakeDir(dbname);
            ftp.GotoDirectory(dbname, false);
            ftp.Upload(filename);
        }

        private void bt_savecon_Click(object sender, EventArgs e)
        {
            ConfigSetValue("SQLServer", tb_sqlserver.Text);
            ConfigSetValue("SQLUser", tb_sqlname.Text);
            ConfigSetValue("SQLPwd", EnPassword.EnPasswordJJ(tb_sqlpwd.Text, 12138, true));
            ConfigSetValue("FtpS", tb_ftpserver.Text);
            ConfigSetValue("FtpUser", tb_ftpuser.Text);
            ConfigSetValue("FtpPort", tb_ftpport.Text);
            ConfigSetValue("FtpPwd", EnPassword.EnPasswordJJ(tb_ftppwd.Text, 12138, true));
            string dbnames = "";
            for (int i = 0; i < lb_db.Items.Count; i++)
            {
                dbnames += lb_db.Items[i].ToString() + ",";
            }
            ConfigSetValue("Dbnames", dbnames);
            if (rb_day.Checked) {
                ConfigSetValue("TimType", "0");
                ConfigSetValue("TimH", numericUpDown1.Value.ToString());
                ConfigSetValue("TimM", numericUpDown2.Value.ToString());
            } else if (rb_jg.Checked) {
                ConfigSetValue("TimType", "1");
                ConfigSetValue("TimH", numericUpDown3.Value.ToString());
                ConfigSetValue("TimM", numericUpDown4.Value.ToString());
            }
        }

        private void bt_getcon_Click(object sender, EventArgs e)
        {
            Initialization();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialization();
        }
        /// <summary>
        /// FTP上传文件阵列
        /// </summary>
        private void ftp_upfiles(){
            File.Delete(filenameed + ".rar");
            string bfpath = Application.StartupPath + "\\";//将当前目录作为备份目录
            //备份文件名 
            tb_re.Text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + "开始执行\r\n";
            for (int i = 0; i < lb_db.Items.Count; i++)
            {
                string bffilename_b = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
                lb_db.SelectedIndex = i;//选中第i列
                string bfdb = lb_db.SelectedItem.ToString();//设置备份数据库为选中文本
                tb_re.Text += "1.正在备份数据库【" + bfdb + "】\r\n";
                string bffilename = bfdb + bffilename_b;
                filenameed = bffilename;
                //1.声明数据库连接字符串
                string constr = "Server=" + tb_sqlserver.Text + ";user=" + tb_sqlname.Text + ";pwd=" + tb_sqlpwd.Text + ";database=master";
                if (sql_backupdatabase(constr, bfdb, bfpath, bffilename) == true)
                {
                    tb_re.Text += "2.正在压缩备份文件【" + bffilename + "】\r\n";
                    rarfile(bfpath + bffilename + ".rar", bfpath + bffilename);
                    tb_re.Text += "3.正在上传备份压缩文件【" + bffilename + ".rar" + "】\r\n";
                    FTPHelper ftp = new FTPHelper(tb_ftpserver.Text + ":" + tb_ftpport.Text, "/", tb_ftpuser.Text, tb_ftppwd.Text);
                    try
                    {
                        //ftp.GetFilesDetailList();
                        //ftp.GetFileList("");
                        ftp_fileup(tb_ftpserver.Text + ":" + tb_ftpport.Text, tb_ftpuser.Text, tb_ftppwd.Text, bfdb, bffilename + ".rar");
                    }
                    catch (Exception ex)
                    {
                        tb_re.Text += "错误:"+ex.Message.ToString()+"\r\n";
                        tb_re.Text += "4.正在清理压缩文件【" + bffilename + ".rar" + "】\r\n";
                    }
                    try
                    {
                        File.Delete(bffilename + ".rar");
                    }
                    catch (Exception ex)
                    {
                        tb_re.Text += "清理压缩文件【" + bffilename + ".rar" + "】错误:"+ex.Message+"\r\n";
                    }
                    
                }
            }
            lb_db.SelectedIndex = -1;
            if (cb_enabledlog.Checked)
            {
                using (StreamWriter sw = new StreamWriter(Application.ExecutablePath + ".log", true))
                {
                    sw.WriteLine(tb_re.Text);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }
    }
}
