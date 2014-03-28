using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isPressid;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Canvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            isPressid = true;
            Draw(e);
        }

        private void Canvas_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            isPressid = false;
            Draw(e);
        }

        private void Canvas_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (isPressid)
            {
                Draw(e);
            }
        }

        private void Draw(MouseEventArgs args)
        {
            var pos = args.GetPosition(Canvas);
            Thickness margin = new Thickness(pos.X-BrushSize/2,pos.Y-BrushSize/2,0,0);
            var ellipse = new Ellipse()
            {
                Margin =  margin,
                Height = BrushSize,
                Width = BrushSize,
                Fill = new SolidColorBrush(Colors.DarkGreen),
            };
            Canvas.Children.Add(ellipse);
        }

        private const double BrushSize = 50;
    }
}
