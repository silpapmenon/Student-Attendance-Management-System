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
    /// Interaction logic for StudentReport.xaml
    /// </summary>
    public partial class StudentReport : UserControl
    {
        public StudentReport()
        {
            InitializeComponent();
            List<StudentModel> studentreport = new List<StudentModel>();
            StudentReportBusinessModel objbusiness = new StudentReportBusinessModel();
            grdStudentReport.ItemsSource = objbusiness.DisplayResult();
        }       
    }
}
