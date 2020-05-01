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
    public partial class 员工界面 : Form
    {
        public 员工界面()
        {
            InitializeComponent();
        }

        private void 员工界面_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new 工资界面().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new 员工资料().Show();
            this.Hide();
        }
    }
}
