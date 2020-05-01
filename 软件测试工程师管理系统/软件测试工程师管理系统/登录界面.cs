using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 软件测试工程师管理系统
{
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._1;
        }

        private void 登录界面_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.tbPassWords.PasswordChar = new char();
            }
            else
            {
                this.tbPassWords.PasswordChar = '*';
            }

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            new 员工资料补充().Show();
            this.Hide();
        }
    }
}
