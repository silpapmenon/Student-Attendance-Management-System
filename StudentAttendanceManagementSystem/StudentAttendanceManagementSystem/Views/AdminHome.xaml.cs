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
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminHome : Window
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Front.Content = new AddStandard();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Front.Content = new AddDivision();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Front.Content = new AddStaff();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Front.Content = new AddStudent();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Front.Content = new StaffReport();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Front.Content = new StudentReport();
        }
    }
}
