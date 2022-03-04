using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentManager
    {
        public void SaveStudentDetails(StudentModel studentModel)
        {
            StudentData studentData = new StudentData ();
            studentData.SaveStudentData(studentModel);
        }
        public List<StudentModel> DisplayResult()
        {
             StudentData studentData = new StudentData();
            return studentData.GetStudentList();
        }
        public void DeleteStudentDetails(StudentModel studentModel)
        {
            StudentData studentData = new StudentData();
            studentData.DeleteData(studentModel);
        }
    }
}


