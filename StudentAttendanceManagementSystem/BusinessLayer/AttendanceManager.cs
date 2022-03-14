using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AttendanceManager
    {
        public List<AttendanceModel> DisplayResult()
        {
            AttendanceReportData attendanceReportData = new AttendanceReportData();
            return attendanceReportData.GetReportData();
        }
    }
}
