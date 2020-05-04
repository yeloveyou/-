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
    public partial class 增加账号 : Form
    {
        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();
        //string SConStr = "server=localhost\\SQLEXPRESS;database=EMS;uid=sa;pwd=980420";

        public 增加账号()
        {
            InitializeComponent();
        }
        public 增加账号(string adminname)
        {
            InitializeComponent();
            textBox2.Text = adminname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                scomm.Connection = sconn;
                scomm.CommandText = string.Format("insert into acnt values ('{0}','1',0,0)", textBox1.Text);
                scomm.ExecuteNonQuery();
                MessageBox.Show("创建成功！");
                sconn.Close();
            }
        }

        private void 增加账号_FormClosed(object sender, FormClosedEventArgs e)
        {
            new 管理员界面(textBox2.Text).Show();
            this.Hide();
        }

        private void 增加账号_Load(object sender, EventArgs e)
        {

        }
    }
}
