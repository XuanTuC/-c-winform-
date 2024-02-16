using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxUID.Text != "" && textBoxPWD.Text != "")
            {
                logincheck();
            }
            else
            {
                MessageBox.Show("请输入用户ID或密码！");
            }


        }
        public void logincheck()
        {
            if (radioButtonUser.Checked == true)//用户
            {
                Dao dao = new Dao();
                string sql = $"select * from Hospital_Account where ID = '{textBoxUID.Text}' and PWD = '{textBoxPWD.Text}'";
                //MessageBox.Show(sql); //测试是否成功
                IDataReader dc =dao.read(sql);
                if(dc.Read())
                {
                    logindata.uid = dc["id"].ToString();//存取用户登录数据,方便在使用的时候调用
                    

                    MessageBox.Show("登陆成功");
                    
                    

                    using (HospitalAccount dlg = new HospitalAccount()) //跳转打开住院账户页面
                    {
                        dlg.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("密码或账户名错误");
                    
                }
                dao.DaoClose();
                
            }

            if (radioButtonAdmin.Checked == true)//管理员
            {
                Dao dao = new Dao();
                string sql = $"select * from Admin where ID =  '{textBoxUID.Text}' and PWD = '{textBoxPWD.Text}'";
                //MessageBox.Show(sql);//测试是否成功
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登陆成功");
                    this.Hide();//隐藏
                    using (main dlg = new main ()) //跳转管理员住面板
                    {
                        dlg.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("密码或账户名错误");
                    
                }
                dao.DaoClose();
            }
            
            
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https");
        }
    }
}
