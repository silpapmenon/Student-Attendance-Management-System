using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class AttendanceSubmit : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AttendanceViewModel attendanceViewModel { get; set; }
        public AttendanceSubmit(AttendanceViewModel attendanceView)
        {
            attendanceViewModel = attendanceView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AttendanceModel attendance = new AttendanceModel();
            attendance.StandardName = attendanceViewModel.StandardName;
            attendance.DivisionName = attendanceViewModel.DivisionName;
            // attendance.Rollno = attendanceViewModel.RollNo;
            attendance.StudentName = attendanceViewModel.StudentName;
            attendance.AttendanceDate = attendanceViewModel.AttendanceDate;
            attendance.Status = attendanceViewModel.Status;
            AttendanceBusinessModel attendanceBusiness = new AttendanceBusinessModel();
            attendanceBusiness.SaveAttendanceData(attendance);
            MessageBox.Show("Value Inserted SuccessFully");
        }

    }
   
    

}
