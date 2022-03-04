using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentData
    {
        public void SaveStudentData(StudentModel studentModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                Student student = new Student();
                student.RollNo = studentModel.RollNo;
                student.StudentName = studentModel.StudentName;
                student.DivisionName = studentModel.DivisionName;
                student.StudentEmail = studentModel.StudentEmail;
                student.StudentMobile =studentModel.StudentMobile;
                student.DOB= studentModel.DOB;
                student.Image= studentModel.Image;
                student.StudentAddress = studentModel.StudentAddress;   
                student.StudentCity = studentModel.StudentCity;
                student.StudentPassword = studentModel.StudentPassword;
                student.StudentUsername = studentModel.StudentUsername;
                student.StudentPincode = studentModel.StudentPincode;
                student.Gender = studentModel.Gender;                               
                studentManagementSystemEntities.Students.Add(student);
                studentManagementSystemEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
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
                studentModel.StudentEmail= item.StudentEmail;
                studentModel.StudentMobile = item.StudentMobile;
                studentModel.DOB = item.DOB;
                studentModel.Image = item.Image;
                studentModel.StudentAddress = item.StudentAddress;
                studentModel.StudentCity= item.StudentCity;
                studentModel.StudentPincode= item.StudentPincode;
                studentModel.Gender= item.Gender;           
                studentModels.Add(studentModel);
            }
            return studentModels;
        }
    }
}
