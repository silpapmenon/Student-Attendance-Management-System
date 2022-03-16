using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class AttendanceViewModel : BaseViewModel
    {
      public AttendanceBusinessModel attendanceBusinessModel = new AttendanceBusinessModel();
    
      
        private int _attendanceId;
        private string _studentName;
        private string _divisionName;
        private DateTime _attendanceDate = DateTime.Now;
        private string _status;
        private int _rollno;
        private string _standardName;

        public int AttendanceId
        {
            get { return _attendanceId; }
            set { _attendanceId = value;
                OnPropertyChanged("AttendanceId");
                 }
        }
        public string StudentName
        {
            get { return _studentName; }
            set
            {
                _studentName = value;
                OnPropertyChanged("StudentName");
            }
        }
        public string DivisionName
        {
            get { return _divisionName; }
            set
            {
                _divisionName = value;
                OnPropertyChanged("DivisionName");
            }
        }
        public DateTime AttendanceDate 
        {
            get { return _attendanceDate; }
            set
            {
                _attendanceDate = value;
                OnPropertyChanged("AttendanceDate");
            }
        }
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
       public int RollNo
        {
            get { return _rollno; }
    set
            {
                _rollno = value;
                OnPropertyChanged("RollNo");
}
        }
        public string StandardName
        {
            get { return _standardName; }
            set
            {
                _standardName = value;
                OnPropertyChanged("StandardName");
            }
        }
        public ICommand AttandanceSubmit { get; set; }

        public AttendanceViewModel()
        {
            AttandanceSubmit = new AttendanceSubmit(this);
        }





    }
}
