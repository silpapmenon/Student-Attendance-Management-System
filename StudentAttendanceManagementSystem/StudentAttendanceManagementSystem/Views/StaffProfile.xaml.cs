using BusinessLayer;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentAttendanceManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StaffProfile.xaml
    /// </summary>
    public partial class StaffProfile : UserControl
    {
        StaffModel staffModels = new StaffModel();
        public StaffProfile(StaffModel staffModel)
        {
            InitializeComponent();
            staffModels = staffModel;
            Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
        void Refresh()
        {
            StaffDetailsBusiness staffDetailsBusiness = new StaffDetailsBusiness();
            grdstaffdetail.ItemsSource = staffDetailsBusiness.GetAllDetails(staffModels);
        }
    }
}
