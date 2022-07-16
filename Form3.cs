using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jingziqi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //Thread.Sleep(500);
            shujuku_waiter();
           
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shujukulianjie("delete from dbo.waiter where wIP='" + lianjiejiance_IP() + "';" );     //返回窗体
        }

        private  void Shujukulianjie(string a)
        {

            SqlConnection conn = new SqlConnection();
            string connectionString = "server=140.143.164.8;database=jingziqi;uid=sa; pwd=Zym702909";
            conn.ConnectionString = connectionString;
            conn.Open();
            Console.WriteLine(conn.State.ToString());
            string sqlStr = a;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlStr;
            cmd.CommandType = System.Data.CommandType.Text;
            Convert.ToInt32(cmd.ExecuteNonQuery());

            //string sqlStr1 = "SELECT * FROM dbo.Table_1 INSERT INTO table1 VALUES('1','a')";
            //SqlCommand cmd1 = new SqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = sqlStr1;
            //cmd.CommandType = System.Data.CommandType.Text;
            //SqlDataReader dataReader = cmd1.ExecuteReader();
            //if (dataReader.HasRows)
            //{
            //    while (dataReader.Read())
            //    {
            //        for (int j = 0; j < dataReader.FieldCount; j++)
            //        {
            //            Console.Write(dataReader[j].ToString() + "\t");
            //        }
            //    }
            //}
            //int i1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
            //Console.Write("共有" + i1.ToString() + "条数据");
            conn.Close();
        }

        private string lianjiejiance_IP()
        {
            try
            {
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData("http://ip.myhostadmin.net"); //从指定网站下载数据
                string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句    
                                                                         //string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                                                                         //Console.WriteLine(pageHtml);//在控制台输入获取的内容

                return pageHtml;
            }
            catch
            {
                return "Error";
            }
        }
        private void shujuku_waiter()
        {
            //Thread.Sleep(100);
            Shujukulianjie("insert into dbo.waiter(wIP,wtime) values ('" + lianjiejiance_IP() + "','" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "');");
            Thread.Sleep(500);
            string a = "select count(*) from dbo.waiter";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已取消！\n即将转入单机模式。", "提示");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
