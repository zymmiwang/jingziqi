using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO.Compression;
using System.Text.RegularExpressions;
using update;
using System.Diagnostics;
using System.Reflection;
using Downloader;

namespace upadte
{

    

    public partial class Form1 : Form
    {
        
        string dir = System.Environment.CurrentDirectory+"\\update-setup.exe";
        string url = "";
        int s = -1;


        public Form1()
        {
            InitializeComponent();

            //test();
            
            
            startupdate();


            /*
            int banben1 = 0, banben2 = 5, banben3 = 0;

            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            Byte[] pageData = MyWebClient.DownloadData("http://jingziqi.xuelun.me "); //从指定网站下载数据
            string pageHtml = Encoding.Default.GetString(pageData);
            //MessageBox.Show(pageHtml);
            int a = Convert.ToInt32(pageHtml[1]), b = Convert.ToInt32(pageHtml[3]), c=Convert.ToInt32(pageHtml[5]);
            
            if (banben1<a||(banben2<b&&banben1==a)||(banben1==a&&banben2==b&&banben3<c))
            {
                label1.Text = "发现新版本："+pageHtml+"\n正在下载更新压缩包...";
;                //MessageBox.Show("yes");
                //System.Net.WebClient d = new System.Net.WebClient();
                //d.DownloadFile("http://jingziqi.xuelun.me/"+pageHtml+".zip", "gengxin.zip");
                Mydownload(pageHtml, "D:\\C#井字棋\\upadte\\upadte\\bin\\Debug", "gengxin.zip");
                label1.Text = "下载完毕";
            }*/
            //startupdate();
        }








        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Byte[] lianjie1;
        private void startupdate()
        {

            /*
            label1.Text = "检查更新中...";
            int banben1 = 0, banben2 = 5, banben3 = 0;
            */


            if (File.Exists("update-setup.exe"))
            {
                File.Delete("update-setup.exe");
            }
            else
            {

            }



            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            
            try
            {
                lianjie1 = MyWebClient.DownloadData("https://github.com/zymmiwang/jingziqi/wiki/update");
            }
            catch
            {
                MessageBox.Show("网络异常，获取自动更新失败。");
                System.Environment.Exit(0);
            }
            string lianjie = Encoding.Default.GetString(lianjie1);
            int a = 0;
            a=lianjie.IndexOf("https://jingziqi.coding.net");
            if (a == 0)
            {
                MessageBox.Show("网络异常，获取自动更新失败。");
                System.Environment.Exit(0);
            }
            url = lianjie.Substring(a,66);
            string version = lianjie.Substring(a - 15, 5);
            //MessageBox.Show(url);
            //MessageBox.Show(version);
            //https://39-165-137-111.d.123pan.cn:30443/123-663/5dadafb4/1813338359-0/5dadafb4cc95f12d77e58fbd9323d297?v=2&t=1670666184&s=0fe9a4464fcbcd26997d47bf27c0cf6d&filename=jingziqi-0.6.7-setup.exe&d=35ff6712
            int v4 = version[0]-48,v5=version[2]-48,v6=version[4]-48;
            int v1 = 0, v2 = 6, v3 = 7;
            if(v1 < v4 || (v2 < v5 && v1 == v4) || (v1 == v4 && v2 == v5 && v3 < v6)){
                //MessageBox.Show("检测到更新：\n版本："+version+"\n是否更新？");

                if (MessageBox.Show("检测到更新：\n版本： " + version + "\n是否更新？", "更新", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //MessageBox.Show("即将打开浏览器进行下载！");
                    //mydownload(url);
                    //System.Diagnostics.Process.Start(url);
                    //System.Environment.Exit(0);
                }
                else
                    System.Environment.Exit(0);      //返回窗体


            }
            else
            {
                MessageBox.Show("暂无更新！");
                System.Environment.Exit(0);
            }
            //MessageBox.Show("1");

            /*
            int a = Convert.ToInt32(pageHtml[1]), b = Convert.ToInt32(pageHtml[3]), c = Convert.ToInt32(pageHtml[5]);

            if (banben1 < a || (banben2 < b && banben1 == a) || (banben1 == a && banben2 == b && banben3 < c))
            {*/
            //label1.Text = "发现新版本：" + pageHtml + "\n正在下载更新压缩包...";
            //shifoufaxian = true;
            //MessageBox.Show("yes");
            //System.Net.WebClient d = new System.Net.WebClient();
            //d.DownloadFile("http://jingziqi.xuelun.me/"+pageHtml+".zip", "gengxin.zip");
            //Mydownload("gengxin.exe", /*"D:\\C#井字棋\\upadte\\upadte\\bin\\Debug", */lianjie);
            //label1.Text = "下载更新完毕";
            //System.Diagnostics.Process.Start("gengxin.exe");
            //ZipFile.ExtractToDirectory("gengxin.zip","gengxin");
            //if (System.IO.File.Exists("gengxin.zip"))
            //{
            //    System.Threading.Thread.Sleep(2000);
            //    System.IO.File.Delete("gengxin.zip");
            //}
            //label1.Text = "解压完毕";
            //Environment.Exit(0);
            /*}
            else
            {
                label1.Text = "未检测到新版本";
            }*/
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
        protected override void OnDownloadFileCompleted(System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("下载完成");
        }*/


        private async void mydownload(string url)
        {
            var downloadOpt = new DownloadConfiguration()
            {
                BufferBlockSize = 10240, // 通常，主机最大支持8000字节，默认值为8000。
                ChunkCount = 8, // 要下载的文件分片数量，默认值为1
                //MaximumBytesPerSecond = 1024 * 1024, // 下载速度限制为1MB/s，默认值为零或无限制
                MaxTryAgainOnFailover = int.MaxValue, // 失败的最大次数
                ParallelDownload = true, // 下载文件是否为并行的。默认值为false
                                         // TempDirectory = "C:\\temp", // 设置用于缓冲大块文件的临时路径，默认路径为Path.GetTempPath()。
                Timeout = 1000, // 每个 stream reader  的超时（毫秒），默认值是1000
                RequestConfiguration = // 定制请求头文件
                {
                    Accept = "*/*",
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    CookieContainer =  new CookieContainer(), // Add your cookies
                    Headers = new WebHeaderCollection(), // Add your custom headers
                    KeepAlive = false,
                    ProtocolVersion = HttpVersion.Version11, // Default value is HTTP 1.1
                    UseDefaultCredentials = false,
                    UserAgent = $"DownloaderSample/{Assembly.GetExecutingAssembly().GetName().Version.ToString(3)}"
                }
            };

            var downloader = new DownloadService(downloadOpt);

            downloader.DownloadFileCompleted += OnDownloadFileCompleted;

            string file = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase+ "update-setup.exe";
            //string url = @"https://39-165-137-111.d.123pan.cn:30443/123-663/5dadafb4/1813338359-0/5dadafb4cc95f12d77e58fbd9323d297?v=2&t=1670666184&s=0fe9a4464fcbcd26997d47bf27c0cf6d&filename=jingziqi-0.6.7-setup.exe&d=35ff6712";
            await downloader.DownloadFileTaskAsync(url, file);

        }

        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            s++;
            if (s == 1) {
                //MessageBox.Show("下载完成！");
                System.Diagnostics.Process.Start("update-setup.exe");
                System.Environment.Exit(0);
            }    
        }


        // <summary>
        /// 去除HTML标记
        /// </summary>
        /// <param name="strHtml">包括HTML的源码 </param>
        /// <returns>已经去除后的文字</returns>
        private string StripHTML(string strHtml)
        {
            string[] aryReg ={
          @"<script[^>]*?>.*?</script>",

          @"<(\/\s*)?!?((\w+:)?\w+)(\w+(\s*=?\s*(([""'])(\\[""'tbnr]|[^\7])*?\7|\w+)|.{0})|\s)*?(\/\s*)?>",
          @"([\r\n])[\s]+",
          @"&(quot|#34);",
          @"&(amp|#38);",
          @"&(lt|#60);",
          @"&(gt|#62);",
          @"&(nbsp|#160);",
          @"&(iexcl|#161);",
          @"&(cent|#162);",
          @"&(pound|#163);",
          @"&(copy|#169);",
          @"&#(\d+);",
          @"-->",
          @"<!--.*\n"

         };

            string[] aryRep = {
           "",
           "",
           "",
           "\"",
           "&",
           "<",
           ">",
           " ",
           "\xa1",//chr(161),
           "\xa2",//chr(162),
           "\xa3",//chr(163),
           "\xa9",//chr(169),
           "",
           "\r\n",
           ""
          };

            string newReg = aryReg[0];
            string strOutput = strHtml;
            for (int i = 0; i < aryReg.Length; i++)
            {
                Regex regex = new Regex(aryReg[i], RegexOptions.IgnoreCase);
                strOutput = regex.Replace(strOutput, aryRep[i]);
            }

            strOutput.Replace("<", "");
            strOutput.Replace(">", "");
            strOutput.Replace("\r\n", "");


            return strOutput;


        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            if (url == "")
            {
                MessageBox.Show("抱歉，网络错误，本次更新取消！");
                System.Environment.Exit(0);
            }
            else
            {
                mydownload(url);
            }

            

        }
    }
}
