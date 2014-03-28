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

namespace WpfApplication4
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

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            var radioBtn = sender as RadioButton;
            if (radioBtn != null)
            {
                var colorText = radioBtn.Content as string;
                switch (colorText)
                {
                    case "Black":
                        Ellipse.Fill = new SolidColorBrush(Colors.Black);
                        break;
                    case "Blue":
                        Ellipse.Fill = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Green":
                        Ellipse.Fill = new SolidColorBrush(Colors.Green);
                        break;
                    case "Cyan":
                        Ellipse.Fill = new SolidColorBrush(Colors.Cyan);
                        break;
                    case "Red":
                        Ellipse.Fill = new SolidColorBrush(Colors.Red);
                        break;
                }
            }
        }
    }
}
