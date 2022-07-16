using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jingziqi
{
    public partial class suopingsetting : Form
    {
        string dir,pwd;
        bool danci = false;
        public suopingsetting()
        {
            InitializeComponent();
        }

        private void suopingsetting_Load(object sender, EventArgs e)
        {

        }
        public class LibWrap

        {

            [DllImport(("winmm.dll "), EntryPoint = "mciSendString", CharSet = CharSet.Auto)]

            public static extern int mciSendString(string lpszCommand, string lpszReturnString,

                        uint cchReturn, int hwndCallback);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择图片或视频文件";
            dialog.Filter = "图片文件(*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg|视频文件(*.mp4;*.avi;*.wmv)|*.mp4;*.avi;*.wmv";
            /*PictureBox PlayScreen = pictureBox1;
            string mciCommand;
            //打开指定位置的视频文件
            mciCommand = "open " + " D:\\picture\\2.wmv " + " alias MyAVI ";
            mciCommand = mciCommand + " parent " + PlayScreen.Handle.ToInt32() + " style child ";
            LibWrap.mciSendString(mciCommand, null, 0, 0);
            Rectangle r = PlayScreen.ClientRectangle;
            mciCommand = " put MyAVI window at 0 0 " + r.Width + " " + r.Height;
            LibWrap.mciSendString(mciCommand, null, 0, 0);
            LibWrap.mciSendString(" play MyAVI ", null, 0, 0);
*/
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LibWrap.mciSendString("close MyAVI ", null, 0, 0);
                dir = dialog.FileName.ToString();
                if(dir.Substring(dir.Length - 3) == "mp4"|| dir.Substring(dir.Length - 3) == "avi"|| dir.Substring(dir.Length - 3) == "wmv")
                {
                    PictureBox PlayScreen = pictureBox1;
                    string mciCommand;
                    //打开指定位置的视频文件
                    mciCommand = "open " + @dir + " alias MyAVI ";

                    mciCommand = mciCommand + " parent " + PlayScreen.Handle.ToInt32() + " style child ";

                    LibWrap.mciSendString(mciCommand, null, 0, 0);

                    Rectangle r = PlayScreen.ClientRectangle;

                    mciCommand = " put MyAVI window at 0 0 " + r.Width + " " + r.Height;

                    LibWrap.mciSendString(mciCommand, null, 0, 0);

                    LibWrap.mciSendString(" play MyAVI ", null, 0, 0);

                }
                else if(dir.Substring(dir.Length - 3) == "jpg"|| dir.Substring(dir.Length - 3) == "png"|| dir.Substring(dir.Length - 4) == "jpeg")
                {

                    pictureBox1.ImageLocation = dir;
                }
                //MessageBox.Show(dialog.FileName.ToString()) ;

            }

        }

        bool kaijiziqi = false;


        private void button2_Click(object sender, EventArgs e)
        {
            
            pwd = pwd.ToUpper();
            lanping suoping = new lanping(dir,pwd);
            LibWrap.mciSendString("close MyAVI ", null, 0, 0);
            if (kaijiziqi == true)
            {
                string exedir = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "suoping-qidong.exe";
                RegistryKey r_local = Registry.CurrentUser;//registrykey r_local = registry.currentuser;
                RegistryKey r_run = r_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                r_run.SetValue("suoping-kajiziqi",exedir);
                r_run.Close();
                r_local.Close();
                RegistryKey r1 = Registry.CurrentUser;
                RegistryKey key1 = r1.CreateSubKey(@"SOFTWARE\jingziqi\Settings");
                key1.SetValue("suoping-dir", dir);
                key1.SetValue("suoping-pw", pwd);
                key1.SetValue("suoping-kaiji", "yes");
                key1.Close();
                r1.Close();
                if (danci == true)
                {
                    RegistryKey r=Registry.CurrentUser;
                    RegistryKey key = r.CreateSubKey(@"SOFTWARE\jingziqi\Settings");
                    key.SetValue("suoping-danci", "yes");
                    key.Close();
                    r.Close();
                }
                else
                {
                    RegistryKey r = Registry.CurrentUser;
                    RegistryKey key = r.CreateSubKey(@"SOFTWARE\jingziqi\Settings");
                    key.SetValue("suoping-danci", "no");
                    key.Close();
                    r.Close();
                }

            }
            else
            {
                RegistryKey r1 = Registry.CurrentUser;
                RegistryKey key1 = r1.CreateSubKey(@"SOFTWARE\jingziqi\Settings");
                key1.SetValue("suoping-kaiji", "no");
                key1.Close();
                r1.Close();
            }
            suoping.ShowDialog();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.无法播放avi且显示VID：xvid等字样？\n  可以尝试安装xvid解码器。url:https://www.xvidmovies.com/codec/\n2.mp4无法播放？\n  此问题因人而异，请更换为wmv格式，目前尚未解决。\n3.视频尽量用wmv格式。");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                kaijiziqi=true;
                checkBox2.Enabled = true;
            }
            else
            {
                kaijiziqi = false;
                checkBox2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                danci = true;
            }
            else
            {
                danci = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pwd = textBox1.Text;

        }
    }
}
