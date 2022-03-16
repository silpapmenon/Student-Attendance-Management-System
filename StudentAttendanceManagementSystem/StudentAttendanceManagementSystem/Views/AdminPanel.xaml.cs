using BusinessLayer;
using EntityLayer.Model;
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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = passwordBox1.Password;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                AdminModel adminModel = new AdminModel();
                adminModel.Username = username;
                adminModel.Password = password;
                AdminUserLoginBusiness adminUserLoginBusiness = new AdminUserLoginBusiness();
                var result = adminUserLoginBusiness.Login(adminModel);
                if (result == true)
                {
                    AdminHome dashboard = new AdminHome();
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
