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

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (grdStaffReport.Items.Count > 0)
        //        {
        //            var value = (grdStaffReport.SelectedItem as StaffModel).StaffID;
        //            StudentModel staffModel = new StudentModel();
        //            StaffManager student = new StaffManager();
        //            staffModel.RollNo = value;
        //            student.DeleteStaffDetails(staffModel);
        //            MessageBox.Show("Staff Deleted :" + staffModel.RollNo);
        //        }
        //        else
        //        {
        //            MessageBox.Show("No Product available for Delete:??");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //private void grdStaffReport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}
