using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class StaffReportViewModel : BaseViewModel
    {
        public ICommand Submit { get; set; }

        private StaffModel _staffReport;
        public List<StaffModel> StaffReports { get; set; }

        //public StaffReportBusinessModel staffReport = new StaffReportBusinessModel();
        public StaffReportViewModel(StaffModel staffModel)
        {
            StaffReports = new List<StaffModel>();
           // StaffReportBusinessModel objbusiness = new StaffReportBusinessModel();
           // StaffReports = objbusiness.DisplayResult();
        }

    }
}
