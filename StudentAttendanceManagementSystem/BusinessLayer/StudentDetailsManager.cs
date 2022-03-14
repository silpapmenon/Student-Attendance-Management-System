using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    internal class StudentDetailsManager
    {
        public List<StudentModel> DisplayResult()
        {
            StudentData studentData = new StudentData();
            return studentData.GetStudentList();
        }
        public void UpdateData(StudentModel studentModel)
        {
            StudentData studentData = new StudentData();
            studentData.UpdateStudentData(studentModel);
        }
    }
}
