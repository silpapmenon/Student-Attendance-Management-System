using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentReportData
    {
        public List<StudentModel> GetStudentList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Students
                         select getdata;

            List<StudentModel> studentModels = new List<StudentModel>();
            foreach (var item in result)
            {
                StudentModel studentModel = new StudentModel();
                studentModel.RollNo = item.RollNo;
                studentModel.StudentName = item.StudentName;
                studentModel.DivisionName = item.DivisionName;
                studentModel.StudentEmail = item.StudentEmail;
                studentModel.StudentMobile = item.StudentMobile;
                studentModel.DOB = item.DOB;
                studentModel.Image = item.Image;
                studentModel.StudentAddress = item.StudentAddress;
                studentModel.StudentCity = item.StudentCity;
                //studentModel.StudentPincode = item.StudentPincode;
                studentModel.Gender = item.Gender;
                studentModels.Add(studentModel);
            }
            return studentModels;

        }
    }
}
