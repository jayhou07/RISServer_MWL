using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dicom.Network;
using Dicom.Log;
using Worklist_SCP;
using NLog.Windows.Forms;
using NLog;
using System.Data.SqlClient;
using Worklist_SCP.Model;

namespace RISServer_MWL
{   
    public partial class Form1 : Form   
    {
        protected static NLog.Logger logger = null;
        DataSet ds = new DataSet();
        SqlDataAdapter da = null;
        SqlCommandBuilder cmdBuilder = null;
        List<WorklistItem> list = new List<WorklistItem>();

        public Form1()
        {
            InitializeComponent();
        }
            
        private void btn_start_Click(object sender, EventArgs e)
        {
            string ip = tIP.Text;
            int port = int.Parse(tPort.Text);
            string cdt = tCdt.Text;
            string cit = tCit.Text;
            WorklistServer.Start(port, cdt, list);
            logger.Info("Server is running.");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            WorklistServer.Stop();
            logger.Info("Server is stopped.");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * from mwl";
            SqlConnection conn1 = new SqlConnection("server=./;Initial Catalog=RIS;integrated security=True");
            try
            {
                conn1.Open();
                da = new SqlDataAdapter(sqlStr, conn1);
                da.Fill(ds, "RIS");
                dgv.DataSource = ds;
                dgv.DataMember = "RIS";

                list = ds.Tables[0].AsEnumerable().Select(
                    dataRow => new WorklistItem
                      { AccessionNumber = dataRow.Field<string>("AccessionNumber"),
                        DateOfBirth = dataRow.Field<DateTime>("DateOfBirth"),
                        PatientID = dataRow.Field<string>("PatientID"),
                        Surname = dataRow.Field<string>("Surname"),
                        Forename = dataRow.Field<string>("Forename"),
                        Sex = dataRow.Field<string>("Sex"),
                        Title = dataRow.Field<string>("Title"),
                        Modality = dataRow.Field<string>("Modality"),
                        ExamDescription = dataRow.Field<string>("ExamDescription"),
                        ExamRoom = dataRow.Field<string>("ExamRoom"),
                        HospitalName = dataRow.Field<string>("HospitalName"),
                        PerformingPhysician = dataRow.Field<string>("PerformingPhysician"),
                        ProcedureID = dataRow.Field<string>("ProcedureID"),
                        ProcedureStepID = dataRow.Field<string>("ProcedureStepID"),
                        StudyUID = dataRow.Field<string>("StudyUID"),
                        ScheduledAET = dataRow.Field<string>("ScheduledAET"),
                        ReferringPhysician = dataRow.Field<string>("ReferringPhysician"),
                        ExamDateAndTime = dataRow.Field<DateTime>("ExamDateAndTime"),
                    }
                    ).ToList();

            }
            catch 
            {
                MessageBox.Show("数据库操作失败!");
            }

            //treeview
            treeView1.ShowPlusMinus = true;
            addChildrenNode();
            //log
            if (logger == null)
            {
                Dicom.Log.LogManager.SetImplementation(NLogManager.Instance);
                logger = NLog.LogManager.GetCurrentClassLogger();
            }

        }           
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmdBuilder = new SqlCommandBuilder(da);
                da.InsertCommand = cmdBuilder.GetInsertCommand();
                da.Update(ds, "RIS");
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add("Modality");
                addChildrenNode();
                MessageBox.Show("数据库更新成功!");
            }
            catch 
            {
                MessageBox.Show("数据库操作失败!");
            }
        }
        public static SqlDataAdapter Con(string sql)
        {
            string sqlStr = sql;//设置sql查询语言
            SqlConnection conn1 = new SqlConnection("server=./;database=RIS;integrated security=True");
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, conn1);
            return da;
        }
        public static DataTable GetData()
        {
            SqlDataAdapter sqlDataAdapter1 = Con("select AccessionNumber from mwl");
            DataTable dt = new DataTable();                                    //创建新的数据表，也可以创建DataSet
            sqlDataAdapter1.Fill(dt);                                          //将查询的数据装入数据表中
            return dt;                                                         //返回得到的数据表
        }
        public void addChildrenNode()
        {
            DataTable dt1 = GetData();                     
            if (dt1.Rows.Count > 0)                                //判断获取的表格是否有数据
            {
                foreach (DataRow dr in dt1.Rows)                   //循环查询获取表格的每行数据
                {
                    TreeNode node = new TreeNode();            //新建TreeNode对象实例

                    node.Tag = dr["AccessionNumber"].ToString();  //将节点id赋给TreeNode对象的tag属性
                    node.Text = dr["AccessionNumber"].ToString();     //节点名称赋给TreeNode对象的text属性
                    treeView1.Nodes[0].Nodes.Add(node);                 //节点插入到treeView1对象中，此处treeView1是自己在winform窗体中的展现菜单的控件
                    //通过传入上一级节点调用添加子节点的代码
                }
            }
        }

    }
}
