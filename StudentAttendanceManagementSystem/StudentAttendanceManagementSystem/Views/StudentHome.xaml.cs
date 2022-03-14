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
using System.Windows.Shapes;

namespace StudentAttendanceManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StudentHome.xaml
    /// </summary>
    public partial class StudentHome : Window
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Front.Content = new StudentMyProfile();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Front.Content = new Leave();
        }
    }
}
