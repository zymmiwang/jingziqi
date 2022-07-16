using System;
using Cmd;

namespace lanpingqingli
{
    class Program
    {
        static void Main(string[] args)
        {
            CMD c = new CMD();
            string a1 = c.cmd("pssuspend.exe winlogon.exe -r");
            //Console.WriteLine("Hello World!");
        }
    }
}
