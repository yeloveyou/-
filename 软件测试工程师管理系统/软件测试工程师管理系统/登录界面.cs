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
   
    public partial class 登录界面 : Form
    {
        SqlConnection sconn = new SqlConnection();
        SqlCommand scomm = new SqlCommand();
        SqlCommand scommtimes = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdreader;
        DataSet ds = new DataSet();       
        //string SConStr = "server=localhost\\SQLEXPRESS;database=EMS;uid=sa;pwd=980420";
        
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
            
            using (SqlConnection sconn = new SqlConnection(SConnStr.SConStr))
            {
                if (!string.Equals(sconn.State.ToString(), "Open"))
                {
                    sconn.Open();
                }
                scomm.Connection = sconn;       
                string username = this.tbUserName.Text;
                string password = this.tbPassWords.Text;

                scomm.CommandText = string.Format("select * from acnt where msg_num='{0}'",username);
                sdreader = scomm.ExecuteReader();
                
                if (sdreader.Read())
                {
                    string DBpassword = sdreader.GetString(sdreader.GetOrdinal("acnt_pwd"));
                    int ACnttimes = sdreader.GetInt32(sdreader.GetOrdinal("acnt_times"));

                    //用户第一次登录
                    if (password.Trim()==DBpassword.Trim()&&ACnttimes==0)//trim去除空格
                    {
                        sconn.Close();
                        sconn.Open();
                        
                        new 员工资料补充(tbUserName.Text).Show();
                        this.Hide();
                        scommtimes.CommandText = string.Format("update acnt set acnt_times=acnt_times+1 where msg_num='{0}'",username);
                        scommtimes.Connection = sconn;
                        scommtimes.ExecuteNonQuery();
                        sconn.Close();
                    }//用户密码输入错误
                    else if(password.Trim() != DBpassword.Trim())
                    {
                        MessageBox.Show("请输入正确的密码");
                    }
                    //用户是老用户
                    else if((password.Trim() == DBpassword.Trim() && ACnttimes != 0))
                    {
                        sconn.Close();
                        sconn.Open();
                        scomm.CommandText = string.Format("select * from msg where msg_num='{0}'", username);                        
                        scomm.Connection = sconn;
                        sdreader = scomm.ExecuteReader();
                        if (sdreader.Read())
                        {
                            string name = sdreader.GetString(sdreader.GetOrdinal("msg_name"));
                            new 员工界面(tbUserName.Text, name).Show();
                            this.Hide();
                        }
                        
                        sconn.Close();
                    }
                }
                else
                {   //管理员登录
                    if (string.Equals(sconn.State.ToString(), "Open"))
                        sconn.Close();
                    sconn.Open();                   
                    scomm.CommandText = string.Format("select * from admin where adminacnt='{0}'", username);;
                    //查询的结果存入reader这个变量中
                    sdreader = scomm.ExecuteReader();
                    if (sdreader.Read())
                    {
                        string DBpassword = sdreader.GetString(sdreader.GetOrdinal("adminpwd"));

                        if (password.Trim() == DBpassword.Trim())//trim去除空格
                        {
                            
                            new 管理员界面(tbUserName.Text).Show();
                            this.Hide();
                            sconn.Close();
                        }
                        else
                        {
                            MessageBox.Show("请输入正确的密码");
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在该用户，请输入正确工号或者管理员账号");
                        this.tbUserName.Text = null;
                        this.tbPassWords.Text= null;
                    }
                    sconn.Close();
                }
                       
                sconn.Close();
                
            }
           

        }
    }
}
