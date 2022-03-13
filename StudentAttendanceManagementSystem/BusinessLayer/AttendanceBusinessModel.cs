using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AttendanceBusinessModel
    {
        public void SaveAttendanceData(AttendanceModel attendanceModel)
        {
            AttendanceData attendanceData = new AttendanceData();
            attendanceData.SaveAttendanceData(attendanceModel);
        }
        public List<AttendanceModel> DisplayResult()
        {
            AttendanceData attendanceData = new AttendanceData();
            return attendanceData.GetAttendanceList();
        }
       

    }
}
