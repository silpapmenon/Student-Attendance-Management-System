using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataAccessLayer
{
    public class StudentDetailData
    {
        public List<StudentModel> GetStudentList(StudentModel studentmodel)
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Students
                         where getdata.StudentUsername == studentmodel.Studentusername

                         select getdata;

            List<StudentModel> studentModels = new List<StudentModel>();
            foreach (var item in result)
            {
                StudentModel studentModel = new StudentModel();
                //studentModel.genderClass = new GenderClass();
                // studentModel.standardClass = new StandardClass();
                // studentModel.StandardName = item.StandardName;
                studentModel.StudentID = item.StudentID;
                studentModel.RollNo = item.RollNo;
                studentModel.StudentName = item.StudentName;
                studentModel.Studentusername = item.StudentUsername;
                studentModel.Studentpassword = item.StudentPassword;
                //studentModel.DivisionName = item.DivisionName;
                studentModel.StudentEmail = item.StudentEmail;
                studentModel.StudentMobile = item.StudentMobile;
                studentModel.DOB = item.DOB;
                //studentModel.Image = item.Image;
                studentModel.StudentAddress = item.StudentAddress;
                studentModel.StudentCity = item.StudentCity;
                studentModel.Studentpincode = item.StudentPincode;
               // studentModel.GenderName = item.Gender;
                //studentModel.standardClass.StandardName = item.Stan
                studentModels.Add(studentModel);
            }
            return studentModels;

        }
        public void UpdateStudentData(StudentModel studentModel)
        {
            try
            {
                StudentManagementSystemEntities students = new StudentManagementSystemEntities();
                
                var query=from studentinfo in students.Students
                          where studentinfo.StudentUsername == studentModel.Studentusername
                          select studentinfo;
                foreach(var item in query)
                {
                    item.RollNo = studentModel.RollNo;
                    item.StudentName = studentModel.StudentName;
                    item.DOB = studentModel.DOB;
                    //item.Gender = studentModel.GenderName;
                    item.StudentEmail = studentModel.StudentEmail;
                    item.StudentMobile = studentModel.StudentMobile;
                    item.StudentAddress = studentModel.StudentAddress;
                    item.StudentCity = studentModel.StudentCity;
                    item.StudentPincode = studentModel.Studentpincode;
                    item.StudentUsername = studentModel.Studentusername;
                    item.StudentPassword = studentModel.Studentpassword;
                }
                students.SaveChanges();
                


            }
            catch (Exception ex)



            {
                throw ex;
            }
        }
    }

}
    

