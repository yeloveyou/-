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
    public partial class 工资界面 : Form
    {
        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();
        //string SConStr = "server=localhost\\SQLEXPRESS;database=EMS;uid=sa;pwd=980420";
        public 工资界面()
        {
            InitializeComponent();
        }
        public 工资界面(string workname)
        {
            InitializeComponent();
            tbworkname.Text = workname;
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
                scomm.CommandText = string.Format("select * from msg where msg_num='{0}'", tbworkname.Text);
                sdreader = scomm.ExecuteReader();
                if (sdreader.Read())
                {
                    string name = sdreader.GetString(sdreader.GetOrdinal("msg_name"));
                    new 员工界面(tbworkname.Text,name).Show();
                    this.Hide();
                }
                sconn.Close();
            }
        }

        private void 工资界面_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 工资界面_Load(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                scomm.Connection = sconn;
                scomm.CommandText = string.Format("select * from msg where msg_num='{0}'", tbworkname.Text);
                sdreader = scomm.ExecuteReader();
                if (sdreader.Read())
                {
                    int workage = sdreader.GetInt32(sdreader.GetOrdinal("msg_year"));
                    int salary = workage * 100 + 4000;
                    textBox1.Text = salary.ToString() + "元";

                    double shuifei = (salary - 3000) * 0.05;
                    textBox2.Text = shuifei.ToString() + "元";

                    int baoxianjin = 200;
                    textBox3.Text = baoxianjin.ToString() + "元";

                    int workagemoney = workage * 100;
                    textBox4.Text = workagemoney.ToString() + "元";

                    double truesalary = salary - shuifei - baoxianjin;
                    textBox5.Text = truesalary.ToString()+"元";
                    sconn.Close();
                    sconn.Open();
                    scomm.CommandText = string.Format("update msg set msg_sa='{0}' where msg_num='{1}'", truesalary,tbworkname.Text);
                    scomm.Connection = sconn;
                    scomm.ExecuteNonQuery();
                    sconn.Close();
                }
                

            }
        }
    }
}
