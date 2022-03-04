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
        private int _studentId;
        private string _divisionName;
        private DateTime _attendanceDate;
        private bool _status;
        private int _staffId;


        public int AttendanceID { get => _attendanceId; set => _attendanceId = value; }
        public int StudentID { get => _studentId; set => _studentId = value; }
        public string DivisionName { get => _divisionName; set => _divisionName = value; }
        public DateTime AttendanceDate { get => _attendanceDate; set => _attendanceDate = value; }
        public bool Status { get => _status; set => _status = value; }
        public int StaffID { get => _staffId; set => _staffId = value; }
    }
}

