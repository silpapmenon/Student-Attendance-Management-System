using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class AttendanceModel
    {
        private int _attendanceId;
        private string _studentName;
        private string _divisionName;
        private DateTime _attendanceDate;
        private string _status;
        private int _rollno;
        private string _standardName;


        public int AttendanceID { get => _attendanceId; set => _attendanceId = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string DivisionName { get => _divisionName; set => _divisionName = value; }
        public DateTime AttendanceDate { get => _attendanceDate; set => _attendanceDate = value; }
        public string Status { get => _status; set => _status = value; }
        public int Rollno { get => _rollno; set => _rollno = value; }
        public string StandardName { get => _standardName; set => _standardName = value; }

       
    }
}

