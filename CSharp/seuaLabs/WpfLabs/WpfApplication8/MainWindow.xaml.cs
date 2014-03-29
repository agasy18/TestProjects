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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition(Canvas);
            Canvas.Children.Add(
                    new Image()
                    {
                        Source = new BitmapImage(new Uri("p.png",UriKind.Relative)),
                        Height = 10,
                        Width = 10,
                        Margin = new Thickness(pos.X-5,pos.Y-5,0,0),
                        RenderTransform = new ScaleTransform(3,3)
                        
                    }
                );
        }
    }
}
