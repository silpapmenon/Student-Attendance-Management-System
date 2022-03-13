using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class LeaveSubmit : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddLeaveViewModel addLeaveViewModel { get; set; }
        public LeaveSubmit(AddLeaveViewModel addLeaveView)
        {
            addLeaveViewModel = addLeaveView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LeaveModel leave = new LeaveModel();
            leave.LeaveID = addLeaveViewModel.LeaveID;
            leave.RollNo = addLeaveViewModel.RollNo;
            leave.Standard=addLeaveViewModel.Standard;
            leave.Division = addLeaveViewModel.Division;
            leave.Message = addLeaveViewModel.Message;
            leave.NumDays=addLeaveViewModel.NumDays;
            leave.Date=addLeaveViewModel.Date;

            LeaveManager leaveManager = new LeaveManager();
            leaveManager.SaveLeaveDetails(leave);
        }
    }
}
