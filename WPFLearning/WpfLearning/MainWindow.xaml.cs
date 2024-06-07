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

namespace WpfLearning
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
        private void LoginButtonClickHandler(object sender, RoutedEventArgs e)
        {
            HomeWindow window = new HomeWindow();
            window.Show();
            this.Hide();

        }
        private void LoginToSignupButtonClickHandler(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignupWindow window = new SignupWindow();
            window.Show();
        }
    }
}
