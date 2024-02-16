using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            
        }
        public void tableID()//依据医护号查询
        {
            dataGridView1.Rows.Clear();//清空旧窗口
            Dao dao = new Dao();
            string sql = $"select * from Medical_Staff where Staff_Id ='{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取
            {
                dataGridView1.Rows.Add(dc[0].ToString(),dc[1].ToString(),dc[2].ToString(),dc[3].ToString());
            }
            dc.Close();//关闭dc实例
            dao.DaoClose();
        }

        public void tableName()//依据姓名查询
        {
            dataGridView1.Rows.Clear();//清空旧窗口
            Dao dao = new Dao();
            string sql = $"select * from Medical_Staff where Name ='{textBox2.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取
            {
                dataGridView1.Rows.Add(dc[0].ToString(),dc[1].ToString(),dc[2].ToString(),dc[3].ToString());
            }
            dc.Close();//关闭dc实例
            dao.DaoClose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tableID();//根据医护号查询
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
            table();//引用table方法，为控件引入数据
            
        }

        public void table()//为控件引入数据
        {
            dataGridView1.Rows.Clear();//清空旧窗口
            Dao dao = new Dao();
            string sql = "select * from Medical_Staff";
            IDataReader dc = dao.read(sql);
            while(dc.Read())//循环读取
            {
                dataGridView1.Rows.Add(dc[0].ToString(),dc[1].ToString(),dc[2].ToString(),dc[3].ToString());
            }
            dc.Close();//关闭dc实例
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)//跳转到添加窗体
        {
            add add1 = new add();
            add1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//删除按钮
        {
            try
            {
                
            
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//id
                //label2.Text = id;
                DialogResult dr=MessageBox.Show("是否确认删除?","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    string sql = $"delete from Medical_Staff where Staff_Id ='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("成功删除！");
                        table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！"+ sql);
                    }
                    dao.DaoClose();
                }
            }
            catch 
            {
                MessageBox.Show("请先选择","消息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)//单击事件
        {
           label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//id;
        }
        //dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + 

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                string Staff_Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string Department = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string Role = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//定义一些变量方便使用
                
                set set1 = new set(Staff_Id, Name, Department, Role);
                set1.ShowDialog();//跳转到修改窗体
                table();//刷新数据
           
            }
            
            catch 
            {
                MessageBox.Show("错误");
            }
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//根据人员姓名查询
        {
            tableName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
