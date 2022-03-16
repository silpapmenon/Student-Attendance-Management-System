using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for StaffLogin.xaml
    /// </summary>
    public partial class StaffLogin : Window
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            string username = textusername.Text;
            string password = passwordbh.Password;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                StaffModel model = new StaffModel();
                model.StaffUserName = username;
                model.StaffPassword = password;
                StaffUserLoginBusiness adminUserLoginBusiness = new StaffUserLoginBusiness();
                var result = adminUserLoginBusiness.GetAll(model);
                if (result == true)
                {
                    StaffModel staffModel = new StaffModel();
                    staffModel.StaffUserName = textusername.Text;
                    StaffHome dashboard = new StaffHome(staffModel);
                    dashboard.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Username or password is incorrect.");

            }
            else
                MessageBox.Show("Enter both fields");
        
        }
    }
}