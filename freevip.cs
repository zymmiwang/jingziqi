using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jingziqi
{
    public partial class freevip : Form
    {
        public freevip()
        {
            InitializeComponent();
        }

        private void buttonBunifuItachi2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("freevip.exe");
        }

        private void buttonBunifuItachi1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("freemusic.exe");
        }
    }
}
