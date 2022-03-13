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
        private int _roleNo;
        private string _message;
        private int _numDays;
        private DateTime _date;
        private string _standard;
        private string _division;

        public int LeaveID { get => _leaveId; set => _leaveId = value; }
        public int RollNo { get => _roleNo; set => _roleNo = value; }
        public string Standard { get => _standard; set => _standard = value; }
        public string Division { get => _division; set => _division = value; }


        public string Message { get => _message; set => _message = value; }
        public int NumDays { get => _numDays; set => _numDays = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
