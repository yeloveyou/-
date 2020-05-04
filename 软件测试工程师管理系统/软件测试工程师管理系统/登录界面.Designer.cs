namespace 软件测试工程师管理系统
{
    partial class 登录界面
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.laPawssWords = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassWords = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserName.Location = new System.Drawing.Point(242, 97);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(49, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "账号";
            // 
            // laPawssWords
            // 
            this.laPawssWords.AutoSize = true;
            this.laPawssWords.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPawssWords.Location = new System.Drawing.Point(242, 147);
            this.laPawssWords.Name = "laPawssWords";
            this.laPawssWords.Size = new System.Drawing.Size(49, 20);
            this.laPawssWords.TabIndex = 1;
            this.laPawssWords.Text = "密码";
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLogin.Location = new System.Drawing.Point(326, 223);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(86, 38);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(354, 92);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(127, 25);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassWords
            // 
            this.tbPassWords.Location = new System.Drawing.Point(354, 142);
            this.tbPassWords.Name = "tbPassWords";
            this.tbPassWords.PasswordChar = '*';
            this.tbPassWords.Size = new System.Drawing.Size(127, 25);
            this.tbPassWords.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(367, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "显示密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // 登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 419);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbPassWords);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.laPawssWords);
            this.Controls.Add(this.lbUserName);
            this.Name = "登录界面";
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.登录界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label laPawssWords;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassWords;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox tbUserName;
    }
}

