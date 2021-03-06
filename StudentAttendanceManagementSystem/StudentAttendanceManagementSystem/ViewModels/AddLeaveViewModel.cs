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
    public class AddLeaveViewModel:BaseViewModel
    {
        private LeaveModel _leaveModel;
        private List<LeaveModel> _leaveViewList;
        public List<LeaveModel> LeaveViewList { get; set; }

        public LeaveManager leaveManager = new LeaveManager();
        public AddLeaveViewModel()
        {
            LeaveViewList = new List<LeaveModel>();
            LeaveManager leaveManager = new LeaveManager();
            LeaveViewList = leaveManager.DisplayResult();

        }
        private int _leaveId;
        private int _roleNo;
        private string _standard;
        private string _division;
        private string _message;
        private int _numDays;
        private DateTime _date;

        public int LeaveID {
            get { return _leaveId; } 
            set { _leaveId = value; 
                OnPropertyChanged("LeaveID");
            }
        }
        public int RollNo
        {
            get { return _roleNo; }
            set
            {
                _roleNo = value;
                OnPropertyChanged("RollNo");
            }
        }
        public string Standard
        {
            get { return _standard; }
            set
            {
                _standard = value;
                OnPropertyChanged("Standard");
            }
        }
        public string Division
        {
            get { return _division; }
            set
            {
                _division = value;
                OnPropertyChanged("Division");
            }
        }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }
        public int NumDays
        {
            get { return _numDays; }
            set
            {
                _numDays = value;
                OnPropertyChanged("NumDays");
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        public ICommand Submit { get; set; }

    }
}
