using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace dummyproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //form1로 이동
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.ShowDialog();
        }

        //객체생성
        MssqlLib mMssqlLib = new MssqlLib();


        //저장버튼
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string age = textBox2.Text;
            mMssqlLib.InsertDB(name, age);
        }

        //MsSQL
        class MssqlLib 
        { 
            public void InsertDB(string name, string age)
        {
            string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};", "DESKTOP-RE8NVEJ\\SQLEXPRESS","test1", "testkhh", "qwe123");
            string sql = "INSERT INTO user_info(name, age) VALUES('"+name+"', '"+age+"')";
 
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
        }//MSSQL


        
    }
}
