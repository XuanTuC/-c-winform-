using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public class Dao//连接方法
    {
        SqlConnection sc;
        public SqlConnection connet()//连接数据库
        {
            string str = @"Data Source=LAPTOP-5RRHG1VQ;Initial Catalog=Hosp;Integrated Security=True";
            sc =new SqlConnection(str);
            sc.Open();
            return sc;

        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connet());
            return cmd;
        }
        public int Execute(string sql)//更新
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql) //读取
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()//关闭数据库连接
        { 
            sc.Close();
        }
    }
}
