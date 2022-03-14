using BusinessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class AttendanceReportViewModel:BaseViewModel
    {
        public ICommand Submit { get; set; }

        private AttendanceModel _attendanceReport;
        public List<AttendanceModel> attendanceReports { get; set; }

        public AttendanceManager attendanceManager = new AttendanceManager();
        public AttendanceReportViewModel(AttendanceModel attendanceModel)
        {
            
        }

    }
}
