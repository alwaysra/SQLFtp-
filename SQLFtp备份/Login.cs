using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnPass;
using DateYN;
using System.Configuration;
using System.Diagnostics;

namespace SQLFtp备份
{
    public partial class Login : Form
    {
        private int passwdint=3;
        private bool csh=false;
        public string enddate="";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkre = new RaDateYN().CheckDate();
            if (checkre == "日期正确")
            {
                if (passwdint > 0)
                {
                    if (textBox1.Text != null)
                    {
                        DateTime todaydt = DateTime.Today;
                        string enddate = EnPassword.CheckEnPassword2("RaSQLFtp", textBox1.Text, 365);
                        if (enddate == "19700101")
                        {
                            MessageBox.Show("授权码无效或已过期!\n还有" + passwdint + "次机会");
                            textBox1.Text = "";
                            textBox1.Focus();
                            passwdint--;
                        }
                        else
                        {
                            Form f1 = new Form1(enddate);
                            f1.Show();
                            this.Hide();
                            ConfigSetValue("Key", textBox1.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("授权已经达到上限,你无权使用!!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else if (checkre == "日期错误")
            {
                MessageBox.Show("非法日期!程序将终止运行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            if (Initialization())
            {
                this.Hide();
                Form f1 = new Form1(enddate);
                f1.Show();
                this.Hide();
            }
            textBox1.Focus();
        }

        private bool Initialization()
        {
            if (csh == false)
            {
                string _key = ConfigGetValue("Key");
                string checkre =new  RaDateYN().CheckDate();
                if (_key != "")
                {
                    if (checkre == "日期正确")
                    {
                        if (passwdint > 0)
                        {
                            EnPassword myen = new EnPassword();
                            enddate = EnPassword.CheckEnPassword2("RaSQLFtp", _key, 365);
                            if (enddate!="19700101")
                            {
                                Debug.WriteLine("_key:" + _key);
                                Debug.WriteLine("返回成功");
                                csh = true;
                                return true;
                            }
                            else
                            {
                                csh = true;
                                MessageBox.Show("授权码无效或已过期!\n还有" + passwdint + "次机会");
                                textBox1.Text = "";
                                textBox1.Focus();
                                passwdint--;
                            }
                        }
                        else
                        {
                            csh = true;
                            MessageBox.Show("授权已经达到上限,你无权使用!!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else if (checkre == "日期错误")
                    {
                        csh = true;
                        MessageBox.Show("非法日期!程序将终止运行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

            }
            return false;
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
