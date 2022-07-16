using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace jingziqi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            kaishi();

        }

        private void kaishi()
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 5;
            output("开始检测网络连接...\n");
            timer1.Enabled = true;
        }

        private int lianjiejiance_ping()
        {
            try
            {
                string listUrl = "140.143.164.8";

                Ping ping = new Ping();
                int iTimeOut = 3000;
                PingReply pingReply = ping.Send(listUrl, iTimeOut);
               // MessageBox.Show("网络正常！", "检测结果");
                return 1;
                //Console.WriteLine("-----------------------------------------------------------------");
                //Console.WriteLine(string.Format("从{0}回复的IP地址：{1}", listUrl[i], pingReply.Address));
                //Console.WriteLine(string.Format("ping耗时：{0}毫秒", pingReply.RoundtripTime));
                //Console.WriteLine(string.Format("ping结果：{0}", pingReply.Status));

            }
            catch (Exception EX)
            {
                //Console.WriteLine(EX.Message);
                //MessageBox.Show("无法连接数据库！\n" + EX.Message, "检测结果");
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output("已取消...");
            timer1.Enabled = false;
            progressBar1.Value = 0;
            this.Close();
        }

        private int lianjiejiance_port() {
            string txtIp = "140.143.164.8";
            string txtPort = "1433";
            if (!string.IsNullOrEmpty(txtPort))
            {
                IPAddress ip = IPAddress.Parse(txtIp);
                IPEndPoint point = new IPEndPoint(ip, int.Parse(txtPort));
                try
                {
                    TcpClient tcp = new TcpClient();
                    tcp.Connect(point);
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return 0;
        }

        private int lianjiejiance_shujuku_login()
        {
            SqlConnection conn = new SqlConnection();
            string connectionString = "server=140.143.164.8;database=jingziqi;uid=sa; pwd=Zym702909";
            conn.ConnectionString = connectionString;
            conn.Open();
            if (conn.State.ToString() == "Open"){
                conn.Close();
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                if (progressBar1.Value == 1)
                {
                    output("检测中 [1/4]   开始尝试ping服务器\n");
                    if (lianjiejiance_ping()==1)
                    output("已ping通服务器\n");
                    else
                    {
                        for(int i = 1; i <= 5; i++)
                        {
                            output("无法ping通服务器，重试中... [" + i.ToString() + "/5]");
                            if (lianjiejiance_ping() == 1)
                            {
                                output("已ping通服务器\n");
                                break;
                            }
                            Thread.Sleep(500);
                        }
                        
                    }

                }
                else if(progressBar1.Value == 2)
                {
                    output("检测中 [2/4]   开始检测服务器端口是否开启\n");
                    if (lianjiejiance_port() == 1)
                    {
                        output("服务器端口已启用\n");
                    }
                    else
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            output("服务器端口未启用，重试中... [" + i.ToString() + "/5]");
                            if (lianjiejiance_port() == 1)
                            {
                                output("服务器端口已启用\n");
                                break;
                            }
                            Thread.Sleep(500);
                        }

                    }
                }
                else if (progressBar1.Value == 3)
                {
                    output("检测中 [3/4]   开始尝试连接数据库\n");
                    if (lianjiejiance_shujuku_login() == 1)
                    {
                        output("已连接上数据库\n");
                    }
                    else
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            output("数据库连接失败，重试中... [" + i.ToString() + "/5]");
                            if (lianjiejiance_shujuku_login() == 1)
                            {
                                output("数据库连接成功\n");
                                break;
                            }
                            Thread.Sleep(200);
                        }

                    }
                }
                //else if (progressBar1.Value == 4)
                //{
                //    output("检测中 [4/5]   开始尝试读写数据库内容\n");
                //    if (lianjiejiance_shujuku_duxie() == 1)
                //    {
                //        output("读写成功\n");
                //    }
                //    else
                //    {
                //        for (int i = 1; i <= 5; i++)
                //        {
                //            output("数据库读写失败，重试中... [" + i.ToString() + "/5]");
                //            if (lianjiejiance_shujuku_duxie() == 1)
                //            {
                //                output("数据库读写成功\n");
                //                break;
                //            }
                //            Thread.Sleep(200);
                //        }

                //    }
                //}
                else if (progressBar1.Value == 4)
                {
                    output("检测中 [4/4]   开始获取公网IP\n");
                    
                    if (lianjiejiance_IP() != "Error")
                    {
                        output("已成功获取公网IP\n");
                    }
                    else
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            output("获取失败，重试中... [" + i.ToString() + "/5]");
                            if (lianjiejiance_shujuku_login() == 1)
                            {
                                output("已成功获取公网IP\n");
                                break;
                            }
                            Thread.Sleep(500);
                        }

                    }
                }
                Thread.Sleep(300);

            }
            else
            {
                output("网络检测完毕！");
                Thread.Sleep(500);
                timer1.Enabled = false;
                this.Close();
            }
        }
        private void output(string log)
        {
            textBox1.AppendText(DateTime.Now.ToString("HH:mm:ss  ") + log + "\r\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
