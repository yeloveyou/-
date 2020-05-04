using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 软件测试工程师管理系统
{
    public partial class 管理员界面 : Form
    {

        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();
        //string SConStr = "server=localhost\\SQLEXPRESS;database=EMS;uid=sa;pwd=980420";

        public 管理员界面()
        {
            InitializeComponent();
        }
        public 管理员界面(string admin)
        {
            InitializeComponent();
            tbname.Text = admin;
        }

        private void 管理员界面_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 管理员界面_Load(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            new 增加账号(tbname.Text).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new 所有员工资料(tbname.Text).Show();
            this.Hide();
        }
    }
}
