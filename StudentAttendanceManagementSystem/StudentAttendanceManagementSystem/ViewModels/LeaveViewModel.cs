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
    public class LeaveViewModel
    {
        public ICommand Submit { get; set; }

        private LeaveModel _leaveData;
        public List<LeaveModel> LeaveData { get; set; }

        //public LeaveBusinessModel leaveBusiness = new LeaveBusinessModel();
        public LeaveViewModel(LeaveModel leave)
        {
            LeaveData = new List<LeaveModel>();
            //LeaveBusinessModel leaveBusinessModel = new LeaveBusinessModel();
           // LeaveData = leaveBusinessModel.DisplayResult();
        }
    }
}
