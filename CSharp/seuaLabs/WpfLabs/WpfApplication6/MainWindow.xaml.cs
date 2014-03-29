using System.ComponentModel;
using System.Windows;

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Close ?", "Hello", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.Yes) return;
            e.Cancel = true;
        }
    }
}
