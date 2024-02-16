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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class bed : Form
    {
        string ID = "";
        public bed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//修改病床信息
        {
           


        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void bed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//添加病床
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")//空值检查
            {
                Dao dao = new Dao();
                string sql = $"insert into Bed values ( '{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')";
                
                int check = dao.Execute(sql);
                if (check != 0)
                {
                    MessageBox.Show("成功添加！");
                    table();

                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
                //清空
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("请确保添加数据前文本框内没有值 或 在添加数据前确保每一项都有值");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table();
        }
        public void table()//为控件引入数据
        {
            dataGridView1.Rows.Clear();//清空旧窗口
            Dao dao = new Dao();
            string sql = "select * from Bed";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();//关闭dc实例
            dao.DaoClose();
        }
        public bed(string BedId,string PatientId,string BedType)
        {
            InitializeComponent();
            ID = textBox5.Text = BedId;
            textBox4.Text = PatientId;
            //BedType

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                string sql = $"update Bed set PatientId='{textBox4.Text}'where BedId ='{textBox5.Text}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功");
                    //table();//刷新数据
                }
            }

            catch
            {
                MessageBox.Show("错误");
            }

        }

        private void button4_Click(object sender, EventArgs e)//刷新按钮
        {
            dataGridView2.Rows.Clear();//清空旧窗口
            Dao dao = new Dao();
            string sql = "select * from Bed";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();//关闭dc实例
            dao.DaoClose();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
