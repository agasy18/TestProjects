using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tnayin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        bool directonClockwise = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int rIndex = i % 80;
            if (directonClockwise)
            {
                rIndex = 80 - i % 80;
            }
            i++;
            object obj = Properties.Resources.ResourceManager.GetObject("img (" + rIndex + ")", Properties.Resources.Culture);
            pictureBox1.Image = ((System.Drawing.Bitmap)(obj));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var nargs = e as MouseEventArgs;
            if (nargs.Button == System.Windows.Forms.MouseButtons.Left)
            {
                timer1.Enabled = !timer1.Enabled;
            }
            else
            {
                directonClockwise = !directonClockwise;
            }
        }

    }
}
