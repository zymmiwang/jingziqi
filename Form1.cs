using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Cmd;
using System.Runtime.InteropServices;
using System.Net;
using System.Media;
using System.Reflection;

namespace jingziqi
{

    public partial class Form1 : Form
    {
        //CMD c = new CMD();
        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]

        public extern static void ShowCursor(int status);

        public Form1()
        {
            InitializeComponent();
            //this.ControlBox = false;
            //DialogResult dr = MessageBox.Show("您要使用单机模式吗？【否则使用远程对战模式】", "模式选择", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (dr != DialogResult.OK)
            //{
            //    yuanchengduizhan();
            //}
            qingling();
        }

        

        private void yuanchengduizhan()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //Class1 shujuku = new Class1();
            //new Form3().Show();
            Form3 form3 = new Form3(); //有没有参数得看你 Form2 的构造函数怎么写的了
            form3.ShowDialog ();
            //string z2 = "drop table stuInfo";
            //string z1 = "create table stuInfo(stuSeat int IDENTITY(100,1),stuName varchar(100) not null,stuNo int unique,stuAge int check(stuAge between 0 and 100) ,stuID varchar(100),stuAddress varchar(100) default '未填写')";
            //lianjiejiance();
            //shujuku.Shujukulianjie(z2);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确定要退出吗？", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Cancel = false;     //关闭窗体
            }
            else
                e.Cancel = true;     //返回窗体
        }



        int s = 0;
        char[] a = new char[15];
        char huoshengzhe='0';
        int huoshengshu_A = 0, huoshengshu_B = 0;



        private void qingling()
        {
            for(int i = 1; i <= 9; i++)
            {
                a[i] = '0';
            }
            huoshengzhe = '0';
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            s = 0;
            label1.Text = "现在轮到A方选择";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            //linshiwenjian_write();
        }

        private void xianshijieguo(char z)
        {
            if(z=='A')
            MessageBox.Show("恭喜A方获胜！", "游戏结果");
            if(z=='B')
            MessageBox.Show("恭喜B方获胜！", "游戏结果");
            string b,c,d;
            b = "当前A获胜" + huoshengshu_A + "场\n";
            c = "当前B获胜" + huoshengshu_B + "场";
            d = b + c;
            MessageBox.Show(d, "游戏结果");
            qingling();
        }

        private void panduan(char z,int n)
        {
            a[n] = z;
            
            for(int i = 1; i <= 9; i++)
            {
                if((a[i] == a[i + 1] && a[i] == a[i + 2] && i % 3 == 1) || (a[i] == a[i + 3] && a[i] == a[i + 6]) || (a[i] == a[i + 4] && a[i] == a[i + 8]) || (a[i] == a[i + 2] && a[i] == a[i + 4] && i == 3)){
                    if (a[i] == 'A')
                    {
                        huoshengzhe = 'A';
                        huoshengshu_A++;
                        xianshijieguo(huoshengzhe);
                        return ;
                    }   
                    if (a[i] == 'B')
                    {
                        huoshengzhe = 'B';
                        huoshengshu_B++;
                        xianshijieguo(huoshengzhe);
                        return;
                    }
                }
            }
            if (s == 9)
            {
                MessageBox.Show("平局！", "游戏结果");
                qingling();
            }
        }
        
        private int xuanzefang()
        {

            

            s++;


            



            if (s % 2 == 1)
            {
                
                return 1;
            }
            else
            {
                
                return 2;
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button1.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 1);
            }

            if (a == 2)
            {
                button1.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 1);
            }
        }



        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 说明ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本游戏为经典小游戏九宫格，是一种非常简单而又上头的小游戏，\n随处可玩而且很少能分出胜负。。。\n", "游戏说明");
        }

        private void 规则ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("游戏规则说明：当任意斜边、横竖边为三个相同字母时，游戏结束。\n-------------------------------------------\n单击对应选项，即可完成选择。\n", "规则说明");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button3.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 3);
            }

            if (a == 2)
            {
                button3.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button2.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 2);
            }

            if (a == 2)
            {
                button2.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false; 
            int a = xuanzefang();
            if (a == 1)
            {
                button4.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 4);
            }

            if (a == 2)
            {
                button4.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button5.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 5);
            }

            if (a == 2)
            {
                button5.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button6.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 6);
            }

            if (a == 2)
            {
                button6.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 6);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button7.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 7);
            }

            if (a == 2)
            {
                button7.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 7);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            int a = xuanzefang();
            if (a == 1)
            {
                button8.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 8);
            }

            if (a == 2)
            {
                button8.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 8);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            
            int a = xuanzefang();
            if (a == 1)
            {
                button9.Text = "A";
                label1.Text = "现在轮到B方选择";
                panduan('A', 9);
            }

            if (a == 2)
            {
                button9.Text = "B";
                label1.Text = "现在轮到A方选择";
                panduan('B', 9);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            鸡汤 jitang = new 鸡汤();
            jitang.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            suopingsetting shezhi = new suopingsetting();
            shezhi.ShowDialog();
            /*lanping weilanping = new lanping();
            weilanping.ShowDialog();*/
            //ShowCursor(1);
        }

        
        /*private void button13_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button13, "随机过滤鼠标或键盘按键，使之出现时而不灵的效果233");
        }*/

        private void button13_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("请注意，本功能久未更新，目前免费音乐酷我业已失效，而观影亦不稳定，请慎重使用。");
            freevip vip = new freevip();
            vip.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int banben1 = 0, banben2 = 5, banben3 = 4;
            /*
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            Byte[] pageData = MyWebClient.DownloadData("https://thrower.cn/1.html"); //从指定网站下载数据

            string pageHtml = Encoding.Default.GetString(pageData);
            Byte[] lianjie1 = MyWebClient.DownloadData("https://thrower.cn/2.html");
            string lianjie = Encoding.Default.GetString(lianjie1);
            //MessageBox.Show(lianjie);
            //MessageBox.Show(pageHtml);
            int a = Convert.ToInt32(pageHtml[1])-48, b = Convert.ToInt32(pageHtml[3])-48, c = Convert.ToInt32(pageHtml[5])-48;

            if (banben1 < a || (banben2 < b && banben1 == a) || (banben1 == a && banben2 == b && banben3 < c))
            {
                MessageBox.Show("发现新版本" + pageHtml + "！需重新安装！");
                System.Diagnostics.Process.Start("update.exe");
                System.Environment.Exit(0);
            }*/
        }

        bool music = false;


        private void pictureBoxBunifuItachi1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new SoundPlayer();
            
            //sp.SoundLocation = jingziqi.Properties.Resources.cengjingdeni.ToString();
            if (music == false)
            {
                music = true;
                pictureBoxBunifuItachi1.Image = jingziqi.Properties.Resources.start;


                
                
                //sp.Play();

                sp.SoundLocation = "music\\cengjingdeni.wav";
                //jingziqi.Properties.Resources.cengjingdeni;


                sp.PlayLooping();
            }
            else if (music == true)
            {
                music = false;
                pictureBoxBunifuItachi1.Image=jingziqi.Properties.Resources.stop;
                sp.Stop();
                sp.Dispose();
            }
        }

        private void 成就ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            achievement chengjiu = new achievement();
            chengjiu.ShowDialog();  
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前程序为0.6.5版本。\n---------------------------------------------\n作者迷惘为了纪念grx而作，希望大家喜欢。\n------------------------------\n2022.3.12 想了很多次，终究放不下这个小程序，虽在那个夏天后已与她如相交过的直线越行越远，但为了回忆过往的美好时光，继续吧。愿她此生安好，而我，铭记她于心中，足以。", "说明");
        }
    }
}
