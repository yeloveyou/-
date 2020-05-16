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
    public partial class 员工资料 : Form
    {
        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();
        //string SConStr = "server=localhost\\SQLEXPRESS;database=EMS;uid=sa;pwd=980420";
        public 员工资料()
        {
            InitializeComponent();
        }
        public 员工资料(string workname)
        {
            InitializeComponent();
            textBox1.Text = workname;
        }

        private void 员工资料_FormClosed(object sender, FormClosedEventArgs e)
        {

            new 员工界面(tbnumber.Text, tbname.Text).Show();
            this.Hide();  
        }

        private void 员工资料_Load(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                scomm.Connection = sconn;
                scomm.CommandText = string.Format("select * from msg where msg_num='{0}'", textBox1.Text);
                sdreader = scomm.ExecuteReader();
                if (sdreader.Read())
                {
                    int salary = sdreader.GetInt32(sdreader.GetOrdinal("msg_sa"));
                    tbnumber.Text = textBox1.Text;
                    tbsalary.Text = salary.ToString();

                }
                sconn.Close();
            }
        }
        //查询资料
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                scomm.Connection = sconn;
                scomm.CommandText = string.Format("select * from msg where msg_num='{0}'", textBox1.Text);
                sdreader = scomm.ExecuteReader();
                if (sdreader.Read())
                {
                    string name = sdreader.GetString(sdreader.GetOrdinal("msg_name"));
                    tbname.Text = name;

                    string sex = sdreader.GetString(sdreader.GetOrdinal("msg_sex"));
                    tbsex.Text = sex;

                   DateTime birthday= sdreader.GetDateTime(sdreader.GetOrdinal("msg_birth"));
                    //tbbirthday.Text = birthday.ToString();
                    tbbirthday.Text = birthday.ToLongDateString();
                                        

                    string locol = sdreader.GetString(sdreader.GetOrdinal("msg_native"));
                    tblocol.Text = locol;

                    string degree = sdreader.GetString(sdreader.GetOrdinal("msg_edu"));
                    tbdegree.Text = degree;

                    string adress = sdreader.GetString(sdreader.GetOrdinal("msg_add"));
                    tbadress.Text = adress;

                    string phone = sdreader.GetString(sdreader.GetOrdinal("msg_tel"));
                    tbphone.Text = phone;

                    int workage = sdreader.GetInt32(sdreader.GetOrdinal("msg_year"));
                    tbworkage.Text = workage.ToString();
                }
                sconn.Close();
            }
        }
        string username, name, sex, local, degree, adress, phone, workage, salary;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbbirthday.Text = dateTimePicker1.Value.ToLongDateString();
        }

        DateTime birthday;
        public void getDate()
        {
            name = tbname.Text;
            sex = tbsex.Text;
            birthday = dateTimePicker1.Value.Date;
            local = tblocol.Text;
            degree = tbdegree.Text;
            adress = tbadress.Text;
            phone = tbphone.Text;
            workage = tbworkage.Text;


        }
        bool issexok, isdegreeok,isphoneok,isbirthday;
        public void panduan()
        {
            getDate();
            //判断性别输入
            if (string.Equals(sex, "男") || string.Equals(sex, "女"))
            {
                issexok = true;
            }
            else
                issexok = false;

            //判断学历输入
            if (string.Equals(degree, "本科") || string.Equals(degree, "小学") || string.Equals(degree, "中学") || string.Equals(degree, "专科") || string.Equals(degree, "硕士") || string.Equals(degree, "博士") || string.Equals(degree, "其他"))
            {
                isdegreeok = true;
            }
            else
                isdegreeok = false;

            //判断电话号码输入
            if (phone.Length == 11&&(phone.Substring(0,3)=="173"|| phone.Substring(0, 3) == "150"|| phone.Substring(0, 3) == "137"))
            {
                isphoneok = true;
            }
            else
                isphoneok = false;
          
      
        }
        //修改信息
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                panduan();
                //对修改的信息进行判断
                if (isdegreeok && issexok&&isphoneok)
                {
                    scomm.CommandText = string.Format("update msg set msg_name='{0}',msg_sex='{1}',msg_birth='{2}',msg_native='{3}'," +
                      "msg_edu='{4}',msg_add='{5}',msg_tel='{6}',msg_year='{7}' where msg_num='{8}' ", name, sex, birthday, local, degree, adress, phone, workage, tbnumber.Text);
                    scomm.Connection = sconn;
                    scomm.ExecuteNonQuery();                   
                    MessageBox.Show("已将数据更新到最新！");
                    sconn.Close();

                    sconn.Open();
                    scommtimes.CommandText = string.Format("update acnt set acnt_updatetimes=acnt_updatetimes+1 where msg_num='{0}'", tbnumber.Text);
                    scommtimes.Connection = sconn;
                    scommtimes.ExecuteNonQuery();
                    sconn.Close();


                }
                else if (!isdegreeok)
                {
                    MessageBox.Show("请输入正确的学位如“本科”“小学”“中学”“专科”“硕士”“博士”“其他”");
                }
                else if (!issexok)
                {
                    MessageBox.Show("请输入性别“男”或者“女”");
                }
                else if (!isphoneok)
                {
                    MessageBox.Show("请输入正确的手机号码！");
                }
            }
        }
    }
}
