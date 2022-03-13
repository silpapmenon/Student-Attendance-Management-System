using BusinessLayer;
using DataAccessLayer;
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
    /// Interaction logic for Attendance.xaml
    /// </summary>
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            AttendanceBusinessModel attendanceBusinessModel = new AttendanceBusinessModel();
            grdattendance.ItemsSource = attendanceBusinessModel.DisplayResult();
        }
        void ClearTextBox()
        {
            txtstudentname.Text = String.Empty;
            txtrollno.Text = String.Empty;
            cmbstatus.Text = String.Empty;
            cmbstandard.Text = String.Empty;
            cmbSelectdivision.Text = String.Empty;
           
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void grdProductData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void grdProductData_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void btndivision_Click(object sender, RoutedEventArgs e)
        {
            AttendanceModel attendanceModel = new AttendanceModel();
            attendanceModel.StudentName = txtstudentname.Text;
            attendanceModel.DivisionName = cmbSelectdivision.Text;
            attendanceModel.StandardName = cmbstandard.Text;
            //attendanceModel.AttendanceDate = DateTime.Now;
            attendanceModel.AttendanceDate = Convert.ToDateTime(dt.Text);
            attendanceModel.Rollno =Convert.ToInt32(txtrollno.Text);
            attendanceModel.Status = cmbstatus.Text;
            AttendanceData attendanceData = new AttendanceData();
            attendanceData.SaveAttendanceData(attendanceModel);
            MessageBox.Show("Value Inserted");
            Refresh();
            ClearTextBox();
        }

       
    }
}
