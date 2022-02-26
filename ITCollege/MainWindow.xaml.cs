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
using ITCollege.Pages;

namespace ITCollege
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // Frame0.NavigationService.Navigate(new UserPage());
        }

        private void AuthBT_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new AuthPage());
            AuthBT.Visibility = Visibility.Hidden;
        }
    }
}
