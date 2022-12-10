
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using 数据库连接;
using Microsoft.Win32;
using Cmd;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace jingziqi
{

    
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pw;
            string str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            CMD c = new CMD();
            RegistryKey rsg = null;
            rsg = Registry.CurrentUser.OpenSubKey("Software\\jingziqi\\Settings", true);
            if (rsg.GetValue("shifoudiyicidakai").ToString() == "1")
            {
                //ZipFile.ExtractToDirectory("tupian.zip", "tupian");
                RegistryKey regWrite;
                regWrite = Registry.CurrentUser.CreateSubKey("Software\\jingziqi\\Settings");
                regWrite.SetValue("shifoudiyicidakai", "0");
                regWrite.Close();
                //c.cmd("copy " + str + "lishu.ttf C:\\Windows\\Fonts\\");

                System.Diagnostics.Process.Start("cert.exe");


            }

            System.Diagnostics.Process.Start("update.exe");

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
