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
    public partial class 修改密码 : Form
    {
        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();
        public 修改密码()
        {
            InitializeComponent();
        }

        public 修改密码(string adminname)
        {
            InitializeComponent();
            textBox4.Text = adminname;
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {

        }

        private void 修改密码_FormClosed(object sender, FormClosedEventArgs e)
        {
            new 管理员界面(textBox4.Text).Show();
            this.Hide();
        }
        string username, oldpassword,newpassword;

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                getDate();
                scomm.Connection = sconn;
                scomm.CommandText = string.Format("select * from acnt where msg_num='{0}'", username);
                sdreader = scomm.ExecuteReader();               
                if (sdreader.Read())
                {
                    oldpassword = sdreader.GetString(sdreader.GetOrdinal("acnt_pwd"));
                    textBox2.Text = oldpassword;
                }
                sconn.Close();
            }
        }

        public void getDate()
        {
            username = textBox1.Text;
            newpassword = textBox3.Text;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {              

                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                getDate();
                scomm.Connection = sconn;
                scomm.CommandText = string.Format("update acnt set acnt_pwd='{0}' where msg_num='{1}'",newpassword,username);
                scomm.ExecuteNonQuery();
                MessageBox.Show("修改成功");

                sconn.Close();
            }
        }
    }
}
