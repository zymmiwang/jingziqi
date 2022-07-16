using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jingziqi
{
    public partial class 鸡汤 : Form
    {
        int s = 0;
        string[] lines = File.ReadAllLines("dutang.txt");
        public 鸡汤()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                button1.Text = "再来一碗！";
                label1.Dock = DockStyle.Fill;
            }
            int suiji = suijishu();
            suiji = suiji % 1437 + 1;
            //string[] lines = File.ReadAllLines("D:" + "\\" + "1.txt");
            
            label1.Text = lines[suiji];
            s++;
        }
        public int suijishu()
        {
            Random rd = new Random();  //无参即为使用系统时钟为种子
            int a=rd.Next();
            return a;
        }

        private void 鸡汤_Load(object sender, EventArgs e)
        {

        }
    }
}
