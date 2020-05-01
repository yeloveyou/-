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
    public partial class 员工资料 : Form
    {
        public 员工资料()
        {
            InitializeComponent();
        }

        private void 员工资料_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new 员工界面().Show();
        }
    }
}
