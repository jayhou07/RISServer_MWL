using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = null;
        SqlCommandBuilder cmdBuilder = null;

        public Form1()
        {
            InitializeComponent();

            string connstr = "Data Source=./;Initial Catalog=RIS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                string strSql = "select * from mwl";              
                da = new SqlDataAdapter(strSql, conn);

                da.Fill(ds, "RIS");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "RIS";

            }
            catch
            {
                MessageBox.Show("数据库操作失败!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdBuilder = new SqlCommandBuilder(da);
            da.InsertCommand = cmdBuilder.GetInsertCommand();
            da.Update(ds, "RIS");
        }
    }
}
