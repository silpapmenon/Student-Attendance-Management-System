using StudentAttendanceManagementSystem.ViewModels;
using StudentAttendanceManagementSystem.Views;
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

namespace StudentAttendanceManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel adminHome = new AdminPanel();
            adminHome.Show();
            this.Close();
        }

        private void btnstudentlogin_Click(object sender, RoutedEventArgs e)
        {
            StudentLogin studentHome = new StudentLogin();
            studentHome.Show();
            this.Close();
        }
    }
}
