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
    /// Interaction logic for StaffReport.xaml
    /// </summary>
    public partial class StaffReport : UserControl
    {
        public StaffReport()
        {
            InitializeComponent();
        }

        //private void btn_Delete(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (grdStaffReport.Items.Count > 0)
        //        {
        //            var value = (grdStaffReport.SelectedItem as StaffModel).StaffEmail;
        //            StaffModel staffModel = new StaffModel();
        //            StaffReportBusinessModel staff = new StaffReportBusinessModel();
        //            staffModel.StaffEmail = value;
        //            staff.DeleteStaffReport(staffModel);
        //            MessageBox.Show("Staff Deleted :" + staffModel.StaffEmail);
        //        }
        //        else
        //        {
        //            MessageBox.Show("No staff available for Delete:??");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

       
    }
}
