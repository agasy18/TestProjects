using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericA.Minimum = decimal.MinValue;
            numericA.Maximum = decimal.MaxValue;
            numericB.Minimum = decimal.MinValue;
            numericB.Maximum = decimal.MaxValue;
        }

        private void any_Changed(object sender, EventArgs e)
        {
            decimal res = 0;
            decimal a = numericA.Value;
            decimal b = numericB.Value;
            try
            {
                if (rbtnPlus.Checked)
                {
                    res = a + b;
                }
                else if (rbtnMinus.Checked)
                {
                    res = a - b;
                }
                else if (rbtnMul.Checked)
                {
                    res = a * b;
                }
                else  //div
                {
                    res = a / b;
                }

                textBoxRes.Text = res.ToString();
            }
            catch
            {
                textBoxRes.Text = "inf";
            }
        }

  
    }
}
