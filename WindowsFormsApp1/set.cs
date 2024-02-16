using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class set : Form
    {
        string ID = "";
        public set()
        {
            InitializeComponent();
        }

        public set(string Staff_Id, string Name, string Department, string Role)
        {
            InitializeComponent();
            ID=textBox1.Text = Staff_Id;
            textBox2.Text = Name;
            textBox3.Text = Department;
            textBox4.Text =Role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sql = $"update Medical_Staff set Staff_Id='{textBox1.Text}',[Name]='{textBox2.Text}',Department='{textBox3.Text}',Role='{textBox4.Text}' where Staff_Id='{ID}' ";
            Dao dao = new Dao();
            if (dao.Execute(sql)>0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }
    }
}
