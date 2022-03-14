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
    public class LeaveReportViewModel : BaseViewModel
    {
        public ICommand Submit { get; set; }

        private LeaveModel _leaveReport;
        public List<LeaveModel> LeaveReport { get; set; }

        public LeaveReportManager leaveReport = new LeaveReportManager();
        public LeaveReportViewModel(LeaveModel leave)
        {
            LeaveReport = new List<LeaveModel>();
            LeaveReportManager objbusiness = new LeaveReportManager();
            LeaveReport = objbusiness.DisplayResult();
        }
    }
}
