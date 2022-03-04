using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class LeaveModel
    {
        private int _leaveId;
        private int _studentId;
        private string _message;
        private int _numDays;
        private DateTime _date;

        public int LeaveID { get => _leaveId; set => _leaveId = value; }
        public int StudentID { get => _studentId; set => _studentId = value; }
        public string Message { get => _message; set => _message = value; }
        public int NumDays { get => _numDays; set => _numDays = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
