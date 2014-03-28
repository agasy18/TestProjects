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

        protected override void OnMouseDown(MouseEventArgs e)
        {
            down = true;
            pList.Add(e.Location);
            Invalidate(new Rectangle(e.Location - new Size(5, 5), new Size(10, 10)));
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            down = false;
            pList.Add(e.Location);
            Invalidate(new Rectangle(e.Location - new Size(5, 5), new Size(10, 10)));
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (down)
            {
                pList.Add(e.Location);
                Invalidate(new Rectangle(e.Location - new Size(5, 5), new Size(10, 10)));
            }
            base.OnMouseMove(e);
        }

        List<Point> pList = new List<Point>();

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var p in pList)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(p-new Size(5,5),new Size(10,10)));
            }
        }

        public bool down { get; set; }

    }
}
