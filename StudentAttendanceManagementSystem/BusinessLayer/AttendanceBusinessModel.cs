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
        public List<StandardModel> standard(StandardModel standardModel)
        {
            AttendanceData attendanceData = new AttendanceData();
            return attendanceData.GetStandard(standardModel);

        }
        public List<DivisionModel> division(DivisionModel divisionModel)
        {
            AttendanceData attendanceData = new AttendanceData();
            return attendanceData.GetDivision(divisionModel);

        }
    }
}
