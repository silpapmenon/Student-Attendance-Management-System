using EntityLayer.Model;
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
    /// Interaction logic for StaffHome.xaml
    /// </summary>
    public partial class StaffHome : Window
    {
        public StaffModel staffModels { get; set; }
        public StaffHome(StaffModel staffModel)
        {
            staffModels = staffModel;
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Front.Content = new StaffProfile(staffModels);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Front.Content = new LeaveReport();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Front.Content = new Attendance();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
