using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
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
            this.DataContext = new AttendanceViewModel();
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


      

       
    }
}
