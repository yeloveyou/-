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
    public partial class 员工资料补充 : Form
    {
        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();
        //string SConStr = "server=localhost\\SQLEXPRESS;database=EMS;uid=sa;pwd=980420";
        public 员工资料补充()
        {
            InitializeComponent();
        }
        public 员工资料补充(string str)
        {
            InitializeComponent();
            tbnumber.Text = str;
        }

        private void 员工资料补充_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        string username,name, sex, local, degree, adress, phone, workage, salary;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbbirthday.Text = dateTimePicker1.Value.ToLongDateString();
        }

        DateTime birthday;
        private void 员工资料补充_Load(object sender, EventArgs e)
        {
            
        }

        private void tbnumber_TextChanged(object sender, EventArgs e)
        {

        }

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
        bool issexok, isdegreeok, isphoneok,isnameok,isaddress,islocol,isworkage;
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
            if (phone.Length == 11 && (phone.Substring(0, 3) == "173" || phone.Substring(0, 3) == "150" || phone.Substring(0, 3) == "137" || phone.Substring(0, 3) == "139" || phone.Substring(0, 3) == "156" || phone.Substring(0, 3) == "178" || phone.Substring(0, 3) == "130" || phone.Substring(0, 3) == "189" || phone.Substring(0, 3) == "155"))
            {
                isphoneok = true;
            }
            else
                isphoneok = false;
            //判断输入名字
            if (tbname.Text != ""&&tbname.Text.Length<50)
            {
                isnameok = true;
            }
            else
                isnameok = false;
            //判断地址
            if (tbadress.Text.Length < 50)
            {
                isaddress = true;
            }
            else
                isaddress = false;
            //判断籍贯
            if (tblocol.Text.Length < 50)
            {
                islocol = true;
            }
            else
                islocol = false;
            //判断工龄
            try
            {
                if (Int32.Parse(tbworkage.Text) < 50 && Int32.Parse(tbworkage.Text) > 0)
                {
                    isworkage = true;
                }
                else
                    isworkage = false;
            }
            catch(Exception e)
            {                
                isworkage = false;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sconn=new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }

                //输入的条件判断
                panduan();
                if (isdegreeok && issexok&&isphoneok&&isnameok&&isaddress&&islocol&&isworkage)
                {
                    scomm.CommandText = string.Format("update msg set msg_name='{0}',msg_sex='{1}',msg_birth='{2}',msg_native='{3}'," +
                      "msg_edu='{4}',msg_add='{5}',msg_tel='{6}',msg_year='{7}' where msg_num='{8}'", name, sex, birthday, local, degree, adress, phone, workage, tbnumber.Text);
                    scomm.Connection = sconn;
                    scomm.ExecuteNonQuery();
                    new 员工界面(tbnumber.Text, tbname.Text).Show();
                    this.Hide();
                }
                else if (!isdegreeok)
                {
                    MessageBox.Show("重新输入！请输入正确的学位如“本科”“小学”“中学”“专科”“硕士”“博士”“其他”");
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
                else if (!issexok)
                {
                    MessageBox.Show("重新输入！请输入性别“男”或者“女”");                   
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
                else if (!isphoneok)
                {
                    MessageBox.Show("重新输入！请输入正确的手机号码！");
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
                else if (!isnameok)
                {
                    MessageBox.Show("重新输入！请输入你的名字！");
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
                else if (!isaddress)
                {
                    MessageBox.Show("重新输入！请输入正确的地址！(不超过50字符)");
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
                else if (!islocol)
                {
                    MessageBox.Show("重新输入！请输入正确的籍贯！(不超过50字符)");
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
                else if (!isworkage)
                {
                    MessageBox.Show("重新输入！请输入正确的工龄（0-50）！");
                    new 员工资料补充(tbnumber.Text).Show();
                    this.Hide();
                }
            }
            
        }
    }
}
