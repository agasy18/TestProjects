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

namespace WpfApplication5
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

        private void BoldCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextLabel.FontWeight = (BoldCheckBox.IsChecked??false) ? FontWeights.Bold : FontWeights.Normal;
        }

        private void ItalicCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            TextLabel.FontStyle = (ItalicCheckBox.IsChecked??false) ? FontStyles.Italic : FontStyles.Normal;
        }

        private void UnderlineCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            TextLabel.FontStyle = (ItalicCheckBox.IsChecked ?? false) ? FontStyles.Italic : FontStyles.Normal;
        }
    }
}
