using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jingziqi
{
    public partial class Form4 : Form
    {
        int s = 0;
        public Form4()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                button2.Text = "开始";
            }

            s++;

            button2.Text = "下一张";

            //if (s % 5 == 0)
            //{

             
            //    button2.Enabled = false;

            //    for(int i = 1; i <= 1000; i++)
           //     {
            //        System.Threading.Thread.Sleep(10);

             //   }

                

             //   button2.Enabled = true;

            //}

            if (s == 100)
            {
                s = 1;
            }

            string str = AppDomain.CurrentDomain.BaseDirectory;



            string str1 = str.Replace("/","\\") ;

            //str1 = str1.Substring(0, str1.Length - 1);

            string a = str1 +  "tupian\\"+s + ".jpg";

            pictureBox1.Image = Image.FromFile(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图片来自作者自己收集，目前共有一百张。、\n\n目前本页面尚不完善2333");
        }
    }
}
