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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void 医护管理工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.ShowDialog();
        }

        private void 住院登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans_fun_regis form1 = new trans_fun_regis();
            form1.ShowDialog();
        }

        private void 病床管理工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bed form2 = new bed();
            form2.ShowDialog();
        }

        private void 病床管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
