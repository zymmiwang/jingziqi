using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using Cmd;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace jingziqi
{
    public partial class lanping : Form
    {
        string pwd="",dir="";
        static char pw1, pw2,pw3,pw4;
        static int miwang2 = 0, miwang3 = 0,miwang1=0;


        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,IntPtr wParam, IntPtr lParam);


        //定义API函数
        [DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(uint esFlags);
        const uint ES_SYSTEM_REQUIRED = 0x00000001;
        const uint ES_DISPLAY_REQUIRED = 0x00000002;
        const uint ES_CONTINUOUS = 0x80000000;

        public static void SleepCtr(bool sleepOrNot)
        {
            if (sleepOrNot)
            {
                //阻止休眠时调用
                SetThreadExecutionState(ES_CONTINUOUS | ES_DISPLAY_REQUIRED | ES_SYSTEM_REQUIRED);
            }
            else
            {
                //恢复休眠时调用
                SetThreadExecutionState(ES_CONTINUOUS);
            }
        }


        //private static char[] password = pwd.ToCharArray();



        public class LibWrap

        {

            [DllImport(("winmm.dll "), EntryPoint = "mciSendString", CharSet = CharSet.Auto)]

            public static extern int mciSendString(string lpszCommand, string lpszReturnString,

                        uint cchReturn, int hwndCallback);

        }

        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]

        public extern static void ShowCursor(int status);
        public lanping(string di,string pw)
        {
            pwd = pw;
            dir = di;
            pw1 = pw[0];
            pw2 = pw[1];
            pw3 = pw[2];
            pw4 = pw[3];

           // this.notifyIcon.Visible = true;

            InitializeComponent();
            if (dir.Substring(dir.Length - 3) == "mp4" || dir.Substring(dir.Length - 3) == "avi" || dir.Substring(dir.Length - 3) == "wmv")
            {
                PictureBox PlayScreen = pictureBox1;
                string mciCommand;
                int SH = Screen.PrimaryScreen.Bounds.Height;
                int SW = Screen.PrimaryScreen.Bounds.Width;
                //打开指定位置的视频文件
                LibWrap.mciSendString("close MyAVI ", null, 0, 0);
                LibWrap.mciSendString("close My1AVI ", null, 0, 0);
                mciCommand = "open " + @dir + " alias My1AVI ";

                mciCommand = mciCommand + " parent " + PlayScreen.Handle.ToInt32() + " style child ";

                LibWrap.mciSendString(mciCommand, null, 0, 0);

                Rectangle r = PlayScreen.ClientRectangle;

                mciCommand = " put My1AVI window at 0 0 " + SW + " " + SH;

                LibWrap.mciSendString(mciCommand, null, 0, 0);

                LibWrap.mciSendString(" play My1AVI ", null, 0, 0);

            }
            else if (dir.Substring(dir.Length - 3) == "jpg" || dir.Substring(dir.Length - 3) == "png" || dir.Substring(dir.Length - 4) == "jpeg")
            {

                pictureBox1.ImageLocation = dir;
            }
            //pictureBox1.ImageLocation = dir;
            this.KeyPreview = true;
            ShowCursor(0);
            Hook_Start();



            //this.WindowState = FormWindowState.Minimized;
            //KeyEventArgs a;
            //lanping_KeyDown(1,1);
            CMD c = new CMD();
            string a1 = c.cmd("pssuspend.exe winlogon.exe");
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,(IntPtr)APPCOMMAND_VOLUME_MUTE);
            SleepCtr(true);




            //for (int i = 0; i < 4; i++)
            //{
            //    if (password[i] >= 97 && password[i] <= 122)         //如果char[i]下标是小写
            //    {
            //        int k = (int)password[i] - 32;
            //        password[i] = (char)k;      //转化成大写
            //    }
            //}
        }

        //string a,b;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void lanping_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Keys key = e.KeyCode;
        //    if (e.Control != true)//如果没按Ctrl键
        //        return;
        //   switch (key)
        //    {

        //        case Keys.NumPad1:
        //            this.Close();
        //            break;


        //            MessageBox.Show("233");

        //    }
        //}




        











        private void lanping_KeyDown(object sender, KeyEventArgs e)
        {
            
            


            if ((e.KeyCode == Keys.F4) && (e.Alt == true)) 
            { 
                e.Handled = true; 
            }


            if ((e.KeyCode == Keys.Tab) && (e.Alt == true))
            {
                e.Handled = true;
            }

            if ((e.KeyCode == Keys.Tab) && (e.Alt == true) && (e.Control == true) )
            {
                e.Handled = true;

            }

                if ((e.KeyCode == Keys.Tab) && (e.KeyCode == Keys.Control)&&(e.KeyCode==Keys.Alt))
                {
                    e.Handled = true;
                }

            //if (e.KeyCode == Keys.Alt) {
            //    a = "Alt";
            //    if (a == Keys.Control.ToString())
            //    {
            //        e.Handled = true;
            //    }
            //    e.Handled = true; 
            //}
            //if (e.KeyCode == Keys.Control)
            //{
            //   if (a == Keys.Alt.ToString())
            //    {
            //        e.Handled = true;
            //    }
            //    a = "Control";
            //}

        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //this.Close();
        }

        



        #region 屏蔽WIN功能键
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        private static int hHook = 0;
        public const int WH_KEYBOARD_LL = 13;


        private static int pwd_r1 = 0,pwd_r2=0,pwd_r3=0,pwd_r4=0;


        //LowLevel键盘截获，如果是WH_KEYBOARD＝2，并不能对系统键盘截取，会在你截取之前获得键盘。 
        private static HookProc KeyBoardHookProcedure;
        private static int miwang = 0;

        //键盘Hook结构函数 
        [StructLayout(LayoutKind.Sequential)]
        public class KeyBoardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
           
        }





        private static char getvkcode(KeyBoardHookStruct myvk)
        {
            if (myvk.vkCode == 48)
            {
                return '0';
            }

            if (myvk.vkCode == 49)
            {
                return '1';
            }

            if (myvk.vkCode == 50)
            {
                return '2';
            }

            if (myvk.vkCode == 51)
            {
                return '3';
            }

            if (myvk.vkCode == 52)
            {
                return '4';
            }

            if (myvk.vkCode == 53)
            {
                return '5';
            }

            if (myvk.vkCode == 54)
            {
                return '6';
            }

            if (myvk.vkCode == 55)
            {
                return '7';
            }

            if (myvk.vkCode == 56)
            {
                return '8';
            }

            if (myvk.vkCode == 57)
            {
                return '9';
            }

            if (myvk.vkCode == 65)
            {
                return 'A';
            }

            if (myvk.vkCode == 66)
            {
                return 'B';
            }

            if (myvk.vkCode == 67)
            {
                return 'C';
            }

            if (myvk.vkCode == 68)
            {
                return 'D';
            }

            if (myvk.vkCode == 69)
            {
                return 'E';
            }

            if (myvk.vkCode == 70)
            {
                return 'F';
            }

            if (myvk.vkCode == 71)
            {
                return 'G';
            }

            if (myvk.vkCode == 72)
            {
                return 'H';
            }

            if (myvk.vkCode == 73)
            {
                return 'I';
            }

            if (myvk.vkCode == 74)
            {
                return 'J';
            }

            if (myvk.vkCode == 75)
            {
                return 'K';
            }

            if (myvk.vkCode == 76)
            {
                return 'L';
            }

            if (myvk.vkCode == 77)
            {
                return 'M';
            }

            if (myvk.vkCode == 78)
            {
                return 'N';
            }

            if (myvk.vkCode == 79)
            {
                return 'O';
            }

            if (myvk.vkCode == 80)
            {
                return 'P';
            }

            if (myvk.vkCode == 81)
            {
                return 'Q';
            }

            if (myvk.vkCode == 82)
            {
                return 'R';
            }

            if (myvk.vkCode == 83)
            {
                return 'S';
            }

            if (myvk.vkCode == 84)
            {
                return 'T';
            }

            if (myvk.vkCode == 85)
            {
                return 'U';
            }

            if (myvk.vkCode == 86)
            {
                return 'V';
            }

            if (myvk.vkCode == 87)
            {
                return 'W';
            }

            if (myvk.vkCode == 88)
            {
                return 'X';
            }

            if (myvk.vkCode == 89)
            {
                return 'Y';
            }

            if (myvk.vkCode == 90)
            {
                return 'Z';
            }

            if (myvk.vkCode == 96)
            {
                return '0';
            }

            if (myvk.vkCode == 97)
            {
                return '1';
            }

            if (myvk.vkCode == 98)
            {
                return '2';
            }

            if (myvk.vkCode == 99)
            {
                return '3';
            }

            if (myvk.vkCode == 100)
            {
                return '4';
            }

            if (myvk.vkCode == 101)
            {
                return '5';
            }

            if (myvk.vkCode == 102)
            {
                return '6';
            }

            if (myvk.vkCode == 103)
            {
                return '7';
            }

            if (myvk.vkCode == 104)
            {
                return '8';
            }

            if (myvk.vkCode == 105)
            {
                return '9';
            }

            return '!';
        }






        //设置钩子 
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //抽掉钩子 
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll")]
        //调用下一个钩子 
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        public static void Hook_Start()
        {
            // 安装键盘钩子 
            if (hHook == 0)
            {
                KeyBoardHookProcedure = new HookProc(KeyBoardHookProc);
                hHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyBoardHookProcedure,
                        GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
                //如果设置钩子失败. 
                if (hHook == 0)
                {
                    Hook_Clear();
                }
            }
        }

        //取消钩子事件 
        public static void Hook_Clear()
        {
            bool retKeyboard = true;
            if (hHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hHook);
                hHook = 0;
            }
            //如果去掉钩子失败. 
            if (!retKeyboard) throw new Exception("UnhookWindowsHookEx failed.");
        }

        //这里可以添加自己想要的信息处理 
        private static int KeyBoardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {

                KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));

                 char kbhcode=getvkcode(kbh);
				 
                if(kbhcode!=pw1&& kbhcode != pw2 && kbhcode != pw3 && kbhcode != pw4)
                {
                    miwang1 = 0;
                    miwang2 = 0;
                    miwang3 = 0;
                }



                if (kbh.vkCode == 91) // 截获左win(开始菜单键) 
                {
                    return 1;
                }

                if (kbh.vkCode == 92)// 截获右win 
                {
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control) //截获Ctrl+Esc 
                {
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.F4 && (int)Control.ModifierKeys == (int)Keys.Alt) //截获alt+f4 
                {
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Tab && (int)Control.ModifierKeys == (int)Keys.Alt) //截获alt+tab
                {
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Shift) //截获Ctrl+Shift+Esc
                {
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Space && (int)Control.ModifierKeys == (int)Keys.Alt) //截获alt+空格 
                {
                    return 1;
                }

                if (kbh.vkCode == 241) //截获F1 
                {
                    return 1;
                }

                //if(getvkcode(kbh) == pw1)
                //{
                //    miwang1 = 1;

                    //Application.Exit();

                    //System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //}

                //if (getvkcode(kbh) == pw2&&miwang1==1)
                //{
                    //if(miwang1==1)
                //    miwang2 = 1;
                    /*else
                    {
                        miwang1 = 0;
                    }*/

                    
                //}

                //if (getvkcode(kbh) == pw3&&miwang1==1&&miwang2==1)
                //{
                    //if (miwang1 == 1&& miwang2 == 1)
                  //      miwang3 = 1;
                    /*else
                    {
                        miwang1 = 0;
                        miwang2 = 0;
                    }*/


                //}

                if (kbhcode == pw4&&miwang1==1&&miwang2==1&&miwang3==1)
                {
                    //if (miwang1 == 1 && miwang2 == 1 && miwang3 == 1)
                    //{
                        Hook_Clear();
                        CMD c = new CMD();
                        string a1 = c.cmd("pssuspend.exe winlogon.exe -r");
                        //SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                        SleepCtr(false);
                        Hook_Clear();
                        //string a2 = c.cmd("lanpingqingli.exe");
                        System.Environment.Exit(0);
                        //System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    /*}
                    else
                    {

                        miwang1 = 0;
                        miwang2 = 0;
                        miwang3 = 0;
                    }*/
                }

                if(kbhcode==pw3&&miwang1==1&&miwang2==1){
					

                    miwang3=1;
                }
				
				if(kbhcode==pw2&&miwang1==1){
					miwang2=1;
				}
				
				if(kbhcode==pw1){
					miwang1=1;
				}

                //if (kbh.vkCode == (int)password[0] )
                //{
                //
                //    pwd_r1 = 1;
                //}

                //if (kbh.vkCode == (int)password[1])
                //{
                //    if (pwd_r1 == 1)
                //    {
                //        pwd_r2 = 1;
                //    }
                //    else
                //    {
                //        pwd_r1 = 0;
                //    }
               // }

                //if (kbh.vkCode == (int)password[2])
                //{
                //    if ((pwd_r1 == 1) && (pwd_r2 == 1))
                //    {
                //        pwd_r3 = 1;
                //    }
                //    else
                 //   {
                //        pwd_r1 = 0;
                //        pwd_r2 = 0;
                //    }
                //}

                //if (kbh.vkCode == (int)password[3])
                //{
                //    if ((pwd_r1 == 1) && (pwd_r2 == 1) &&(pwd_r3==1))
                //    {
                //        Hook_Clear();
                //       CMD c = new CMD();
                //        string a1 = c.cmd("pssuspend.exe winlogon.exe -r");
                //        string a2 = c.cmd("lanpingqingli.exe");
                //        //SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                //       SleepCtr(false);
                //        Hook_Clear();
                //        System.Environment.Exit(0);
                //
                //    }
                //    else
                //    {
                //        pwd_r1 = 0;
                //        pwd_r2 = 0;
                //        pwd_r3 = 0;
                //    }
                //}




                if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt + (int)Keys.Delete)      //截获Ctrl+Alt+Delete 
                {
                    return 1;
                }

                if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Shift) //截获Ctrl+Shift 
                {
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Space && (int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt) //截获Ctrl+Alt+空格 
                {
                    return 1;
                }
                if (kbh.vkCode == (int)Keys.Tab && (int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt) //截获Ctrl+Alt+Tab 
                {
                    return 1;
                }
            }

            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }
        public static void TaskMgrLocking(bool bLock)
        {
            if (bLock)
            {
                try
                {
                    RegistryKey r = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
                    r.SetValue("DisableTaskmgr", "1"); //屏蔽任务管理器 
                }
                catch
                {
                    RegistryKey r = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                    r.SetValue("DisableTaskmgr", "0");
                }
            }
            else
            {
                Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            }
        }



        #endregion



        




        private void lanping_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hook_Clear();
            CMD c = new CMD();
            string a1 = c.cmd("pssuspend.exe winlogon.exe -r");
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
            SleepCtr(false);
            //string a2 = c.cmd("lanpingqingli.exe");
        }




        
    }
}
