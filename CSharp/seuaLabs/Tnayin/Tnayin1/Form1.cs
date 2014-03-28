using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tnayin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple message box");
        }

        private void txtBoxForLabel_TextChanged(object sender, EventArgs e)
        {
            lblForTxtBox.Text = txtBoxForLabel.Text;
        }
    }
}
