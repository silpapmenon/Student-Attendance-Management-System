using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AttendanceData
    {
       
        public void SaveAttendanceData(AttendanceModel attendanceModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                Attendance attendance = new Attendance();
                attendance.StandardName = attendanceModel.StandardName;
                attendance.DivisionName = attendanceModel.DivisionName;
                attendance.RollNo = attendanceModel.Rollno;
                attendance.StudentName = attendanceModel.StudentName;
                attendance.Status = attendanceModel.Status;
                attendance.AttendanceDate = attendanceModel.AttendanceDate;
                studentManagementSystemEntities.Attendances.Add(attendance);
                studentManagementSystemEntities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AttendanceModel> GetAttendanceList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Attendances
                         select getdata;

            List<AttendanceModel> attendanceModels = new List<AttendanceModel>();
            foreach (var item in result)
            {
                AttendanceModel attendanceModel = new AttendanceModel();
                attendanceModel.StandardName = item.StandardName;
                attendanceModel.DivisionName = item.DivisionName;
                attendanceModel.StudentName = item.StudentName;
                attendanceModel.Rollno = item.RollNo;
                attendanceModel.Status = item.Status;
                attendanceModel.AttendanceDate = item.AttendanceDate;
                attendanceModels.Add(attendanceModel);
            }
            return attendanceModels;

        }
       
    }
}