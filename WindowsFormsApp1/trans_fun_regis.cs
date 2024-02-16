using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class trans_fun_regis : Form
    {
        public trans_fun_regis()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//住院登记
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {//空值检查
                if (!Regex.IsMatch(textBox1.Text, "^[0-9]{4}-ZC-[0-9]{4}-[0-9]{5}$"))//规范检查
                {
                    MessageBox.Show("住院号格式不正确，请按照规则输入。");
                    return;
                }
                Dao dao = new Dao();
                string sql = $"insert into Hospitalization values ('{textBox1.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}')";
                //dao.Execute(sql);
                int check = dao.Execute(sql);
                if (check != 0)
                {
                    MessageBox.Show("成功保存并添加！");

                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
                //清空显示区域
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            else
            {
                MessageBox.Show("请确保添加数据前文本框内没有值 或 在添加数据前确保每一项都有值");
            }
        }
    }
}
