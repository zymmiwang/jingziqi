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

namespace upadte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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




        private void Mydownload(string fileName,string url)
        {
            WebClient wc = new WebClient();
            /*if (File.Exists(localPath + fileName))
            {
                File.Delete(localPath + fileName);
            }
            if (Directory.Exists(localPath) == false)
            {
                Directory.CreateDirectory(localPath);
            }*/
            wc.DownloadFile(url, fileName);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startupdate()
        {
            /*
            label1.Text = "检查更新中...";
            int banben1 = 0, banben2 = 5, banben3 = 0;
            */
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            
            Byte[] lianjie1 = MyWebClient.DownloadData("https://jingziqi.coding.net/s/70cd12fd-2cda-455f-ba5c-86e215beeb2b/6");
            string lianjie = Encoding.Default.GetString(lianjie1);
            int a = 0;
            a=lianjie.IndexOf("jingziqi");
            string url = lianjie.Substring(a,68);
            MessageBox.Show(url);
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
            startupdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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





        }
}
