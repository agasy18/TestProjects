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

namespace WpfApplication7
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

        private Thickness[] tksArr = new Thickness[]
        {
            new Thickness(0,0,0,0),
            new Thickness(0,100,0,0),
            new Thickness(0,200,0,0),
            new Thickness(0,300,0,0),
            new Thickness(150,0,0,0),
            new Thickness(150,100,0,0),
            new Thickness(150,200,0,0),
            new Thickness(150,300,0,0),            
            new Thickness(300,0,0,0),
            new Thickness(300,100,0,0),
            new Thickness(300,200,0,0),
            new Thickness(300,300,0,0),            
            new Thickness(400,0,0,0),
            new Thickness(400,100,0,0),
            new Thickness(400,200,0,0),
            new Thickness(400,300,0,0),
        };

        private readonly Random random = new Random();
        private int lastIndex = 0;

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            int newIndex;
            do
            {
                newIndex = random.Next(0, tksArr.Length-1);
            } while (newIndex == lastIndex);
            lastIndex = newIndex;
            Button.Margin = tksArr[newIndex];
        }
    }
}
