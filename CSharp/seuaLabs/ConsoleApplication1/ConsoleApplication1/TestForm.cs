using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;
namespace ConsoleApplication1
{
    public partial class TestForm : Form
    {
        
        public TestForm()
        {
            
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.TranslateTransform(200, 0);

            e.Graphics.ScaleTransform(4, 3); 
            e.Graphics.RotateTransform(30);
            e.Graphics.FillPolygon(new LinearGradientBrush(new PointF(0,0),new PointF(100,100), Color.Yellow,Color.Red), new System.Drawing.Point[]
                {
                    new Point(2,40),
                    new Point(44,44),
                    new Point(50,6),
                    new Point(62,44),
                    new Point(97,40),
                    new Point(66,64),
                    new Point(78,96),
                    new Point(48,75),
                    new Point(20,96),
                    new Point(37,62)
                });
            e.Graphics.ResetTransform();
            e.Graphics.DrawString("This is a Star!", new Font("Syflaen", 15), new SolidBrush(Color.Red), new Point(100, 100));
            
        }
    }
}
