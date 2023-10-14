using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TASK1
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            byte r = (byte)Random.Shared.Next(0, 255);
            byte g = (byte)Random.Shared.Next(0, 255);
            byte b = (byte)Random.Shared.Next(0, 255);

            Button? button = sender as Button;
            button.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            MessageBox.Show($"Width:{button.Width}\nHeight:{button.Height}\nName:{button.Content}\nColor:{button.Background.ToString()}");

        }

        private void btn_1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button? button = sender as Button;
            panel.Children.Remove(button);

            Window.Title = button.Content.ToString();
        }
    }
}
//ByVC