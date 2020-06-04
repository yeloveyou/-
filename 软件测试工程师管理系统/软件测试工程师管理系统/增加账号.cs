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
        string zhanghao;
        public 增加账号(string adminname)
        {
            InitializeComponent();
            textBox2.Text = adminname;
            zhanghao = adminname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {

                try
                {
                    if (!string.Equals(sconn.State.ToString(), "Open"))
                    {
                        sconn.Open();
                    }
                    scomm.Connection = sconn;
                    bool a;
                    a = int.TryParse(textBox1.Text,out int b);
                    if (textBox1.Text == ""||!a)
                    {
                        MessageBox.Show("请输入正确的工号");

                        new 增加账号(textBox1.Text).Show();
                        this.Hide();

                    }                
                    else
                    {
                        scomm.CommandText = string.Format("insert into acnt values ('{0}','1',0,0)", textBox1.Text);
                        scomm.ExecuteNonQuery();
                        MessageBox.Show("创建成功！");
                        sconn.Close();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("请输入正确的工号，不要重复和非法字符");
                    new 增加账号(textBox1.Text).Show();
                    this.Hide();
                }
                
            }
        }

        private void 增加账号_FormClosed(object sender, FormClosedEventArgs e)
        {
            new 管理员界面(zhanghao).Show();
            this.Hide();
        }

        private void 增加账号_Load(object sender, EventArgs e)
        {

        }
    }
}
