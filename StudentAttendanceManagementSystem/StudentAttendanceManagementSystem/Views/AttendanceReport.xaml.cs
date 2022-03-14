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
    /// Interaction logic for AttendanceReport.xaml
    /// </summary>
    public partial class AttendanceReport : UserControl
    {
        public AttendanceReport()
        {
            InitializeComponent();
            List<AttendanceModel> attendanceReport = new List<AttendanceModel>();
            AttendanceManager objbusiness = new AttendanceManager();
            grdAttendance.ItemsSource = objbusiness.DisplayResult();
        }
    }
}
