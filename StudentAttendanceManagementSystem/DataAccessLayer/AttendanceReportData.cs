using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AttendanceReportData
    {
        public List<AttendanceModel> GetReportData()
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                var result = from getdata in studentManagementSystemEntities.Attendances
                             select getdata;

                List<AttendanceModel> attendanceModels = new List<AttendanceModel>();
                foreach (var item in result)
                {
                    AttendanceModel attendanceModel = new AttendanceModel();
                    attendanceModel.AttendanceID = item.AttendanceID;
                    attendanceModel.StandardName = item.StandardName;
                    attendanceModel.DivisionName = item.DivisionName;
                    attendanceModel.StudentName = item.StudentName;
                    attendanceModel.Rollno = item.RollNo;
                    attendanceModel.AttendanceDate = item.AttendanceDate;
                    attendanceModel.Status = item.Status;

                    attendanceModels.Add(attendanceModel);
                }
                return attendanceModels;




            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

