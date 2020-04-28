namespace SQLFtp备份
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_adddb = new System.Windows.Forms.Button();
            this.bt_deldb = new System.Windows.Forms.Button();
            this.lb_db = new System.Windows.Forms.ListBox();
            this.cb_data = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sqlpwd = new System.Windows.Forms.TextBox();
            this.tb_sqlname = new System.Windows.Forms.TextBox();
            this.tb_sqlserver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_enabledlog = new System.Windows.Forms.CheckBox();
            this.tb_djs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_jg = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rb_day = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_ftptext = new System.Windows.Forms.Button();
            this.tb_ftppwd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_ftpuser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ftpport = new System.Windows.Forms.TextBox();
            this.tb_ftpserver = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.tb_re = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_savecon = new System.Windows.Forms.Button();
            this.bt_getcon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_adddb);
            this.groupBox1.Controls.Add(this.bt_deldb);
            this.groupBox1.Controls.Add(this.lb_db);
            this.groupBox1.Controls.Add(this.cb_data);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_sqlpwd);
            this.groupBox1.Controls.Add(this.tb_sqlname);
            this.groupBox1.Controls.Add(this.tb_sqlserver);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账套选择";
            // 
            // bt_adddb
            // 
            this.bt_adddb.Location = new System.Drawing.Point(190, 145);
            this.bt_adddb.Name = "bt_adddb";
            this.bt_adddb.Size = new System.Drawing.Size(75, 23);
            this.bt_adddb.TabIndex = 9;
            this.bt_adddb.Text = "添加账套";
            this.bt_adddb.UseVisualStyleBackColor = true;
            this.bt_adddb.Click += new System.EventHandler(this.bt_adddb_Click);
            // 
            // bt_deldb
            // 
            this.bt_deldb.Location = new System.Drawing.Point(54, 145);
            this.bt_deldb.Name = "bt_deldb";
            this.bt_deldb.Size = new System.Drawing.Size(75, 23);
            this.bt_deldb.TabIndex = 8;
            this.bt_deldb.Text = "移除账套";
            this.bt_deldb.UseVisualStyleBackColor = true;
            this.bt_deldb.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_db
            // 
            this.lb_db.FormattingEnabled = true;
            this.lb_db.ItemHeight = 12;
            this.lb_db.Location = new System.Drawing.Point(295, 20);
            this.lb_db.Name = "lb_db";
            this.lb_db.Size = new System.Drawing.Size(237, 148);
            this.lb_db.TabIndex = 2;
            this.lb_db.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cb_data
            // 
            this.cb_data.FormattingEnabled = true;
            this.cb_data.Location = new System.Drawing.Point(54, 115);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(231, 20);
            this.cb_data.TabIndex = 7;
            this.cb_data.DropDown += new System.EventHandler(this.cb_data_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "账  套：";
            // 
            // tb_sqlpwd
            // 
            this.tb_sqlpwd.Location = new System.Drawing.Point(54, 84);
            this.tb_sqlpwd.Name = "tb_sqlpwd";
            this.tb_sqlpwd.PasswordChar = '*';
            this.tb_sqlpwd.Size = new System.Drawing.Size(231, 21);
            this.tb_sqlpwd.TabIndex = 5;
            this.tb_sqlpwd.Text = "1";
            // 
            // tb_sqlname
            // 
            this.tb_sqlname.Location = new System.Drawing.Point(54, 53);
            this.tb_sqlname.Name = "tb_sqlname";
            this.tb_sqlname.Size = new System.Drawing.Size(231, 21);
            this.tb_sqlname.TabIndex = 4;
            this.tb_sqlname.Text = "sa";
            // 
            // tb_sqlserver
            // 
            this.tb_sqlserver.Location = new System.Drawing.Point(54, 22);
            this.tb_sqlserver.Name = "tb_sqlserver";
            this.tb_sqlserver.Size = new System.Drawing.Size(231, 21);
            this.tb_sqlserver.TabIndex = 3;
            this.tb_sqlserver.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_enabledlog);
            this.groupBox2.Controls.Add(this.tb_djs);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rb_jg);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.rb_day);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定时设置";
            // 
            // cb_enabledlog
            // 
            this.cb_enabledlog.AutoSize = true;
            this.cb_enabledlog.Checked = true;
            this.cb_enabledlog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_enabledlog.Location = new System.Drawing.Point(447, 18);
            this.cb_enabledlog.Name = "cb_enabledlog";
            this.cb_enabledlog.Size = new System.Drawing.Size(72, 16);
            this.cb_enabledlog.TabIndex = 11;
            this.cb_enabledlog.Text = "启用日志";
            this.cb_enabledlog.UseVisualStyleBackColor = true;
            // 
            // tb_djs
            // 
            this.tb_djs.Location = new System.Drawing.Point(277, 47);
            this.tb_djs.Name = "tb_djs";
            this.tb_djs.ReadOnly = true;
            this.tb_djs.Size = new System.Drawing.Size(86, 21);
            this.tb_djs.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "倒计时：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "分钟";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(146, 47);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(45, 21);
            this.numericUpDown4.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "小时";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(60, 47);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(45, 21);
            this.numericUpDown3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "时";
            // 
            // rb_jg
            // 
            this.rb_jg.AutoSize = true;
            this.rb_jg.Location = new System.Drawing.Point(10, 49);
            this.rb_jg.Name = "rb_jg";
            this.rb_jg.Size = new System.Drawing.Size(47, 16);
            this.rb_jg.TabIndex = 3;
            this.rb_jg.TabStop = true;
            this.rb_jg.Text = "间隔";
            this.rb_jg.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(134, 18);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 21);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 21);
            this.numericUpDown1.TabIndex = 1;
            // 
            // rb_day
            // 
            this.rb_day.AutoSize = true;
            this.rb_day.Location = new System.Drawing.Point(10, 20);
            this.rb_day.Name = "rb_day";
            this.rb_day.Size = new System.Drawing.Size(47, 16);
            this.rb_day.TabIndex = 0;
            this.rb_day.TabStop = true;
            this.rb_day.Text = "每天";
            this.rb_day.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.bt_ftptext);
            this.groupBox3.Controls.Add(this.tb_ftppwd);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tb_ftpuser);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tb_ftpport);
            this.groupBox3.Controls.Add(this.tb_ftpserver);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FTP设置";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(351, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "匿名用户";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_ftptext
            // 
            this.bt_ftptext.Location = new System.Drawing.Point(354, 51);
            this.bt_ftptext.Name = "bt_ftptext";
            this.bt_ftptext.Size = new System.Drawing.Size(75, 23);
            this.bt_ftptext.TabIndex = 8;
            this.bt_ftptext.Text = "测试连接";
            this.bt_ftptext.UseVisualStyleBackColor = true;
            this.bt_ftptext.Click += new System.EventHandler(this.bt_ftptext_Click);
            // 
            // tb_ftppwd
            // 
            this.tb_ftppwd.Location = new System.Drawing.Point(228, 52);
            this.tb_ftppwd.Name = "tb_ftppwd";
            this.tb_ftppwd.PasswordChar = '*';
            this.tb_ftppwd.ReadOnly = true;
            this.tb_ftppwd.Size = new System.Drawing.Size(106, 21);
            this.tb_ftppwd.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "密码：";
            // 
            // tb_ftpuser
            // 
            this.tb_ftpuser.Location = new System.Drawing.Point(64, 52);
            this.tb_ftpuser.Name = "tb_ftpuser";
            this.tb_ftpuser.ReadOnly = true;
            this.tb_ftpuser.Size = new System.Drawing.Size(100, 21);
            this.tb_ftpuser.TabIndex = 5;
            this.tb_ftpuser.Text = "anonymous";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "用户名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "端口：";
            // 
            // tb_ftpport
            // 
            this.tb_ftpport.Location = new System.Drawing.Point(277, 21);
            this.tb_ftpport.Name = "tb_ftpport";
            this.tb_ftpport.Size = new System.Drawing.Size(57, 21);
            this.tb_ftpport.TabIndex = 2;
            this.tb_ftpport.Text = "21";
            // 
            // tb_ftpserver
            // 
            this.tb_ftpserver.Location = new System.Drawing.Point(64, 21);
            this.tb_ftpserver.Name = "tb_ftpserver";
            this.tb_ftpserver.Size = new System.Drawing.Size(160, 21);
            this.tb_ftpserver.TabIndex = 1;
            this.tb_ftpserver.Text = "127.0.0.1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "FTPIP：";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(475, 380);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "启动";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // tb_re
            // 
            this.tb_re.Location = new System.Drawing.Point(12, 409);
            this.tb_re.Multiline = true;
            this.tb_re.Name = "tb_re";
            this.tb_re.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_re.Size = new System.Drawing.Size(538, 197);
            this.tb_re.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "当前进度";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "立即执行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_savecon
            // 
            this.bt_savecon.Location = new System.Drawing.Point(313, 380);
            this.bt_savecon.Name = "bt_savecon";
            this.bt_savecon.Size = new System.Drawing.Size(75, 23);
            this.bt_savecon.TabIndex = 7;
            this.bt_savecon.Text = "保存配置";
            this.bt_savecon.UseVisualStyleBackColor = true;
            this.bt_savecon.Click += new System.EventHandler(this.bt_savecon_Click);
            // 
            // bt_getcon
            // 
            this.bt_getcon.Location = new System.Drawing.Point(232, 380);
            this.bt_getcon.Name = "bt_getcon";
            this.bt_getcon.Size = new System.Drawing.Size(75, 23);
            this.bt_getcon.TabIndex = 8;
            this.bt_getcon.Text = "读取配置";
            this.bt_getcon.UseVisualStyleBackColor = true;
            this.bt_getcon.Click += new System.EventHandler(this.bt_getcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 618);
            this.Controls.Add(this.bt_getcon);
            this.Controls.Add(this.bt_savecon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_re);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SQLFtp备份";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_db;
        private System.Windows.Forms.ComboBox cb_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sqlpwd;
        private System.Windows.Forms.TextBox tb_sqlname;
        private System.Windows.Forms.TextBox tb_sqlserver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_adddb;
        private System.Windows.Forms.Button bt_deldb;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rb_day;
        private System.Windows.Forms.RadioButton rb_jg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_djs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bt_ftptext;
        private System.Windows.Forms.TextBox tb_ftppwd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_ftpuser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ftpport;
        private System.Windows.Forms.TextBox tb_ftpserver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.TextBox tb_re;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_savecon;
        private System.Windows.Forms.Button bt_getcon;
        private System.Windows.Forms.CheckBox cb_enabledlog;
    }
}

