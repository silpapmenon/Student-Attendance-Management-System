using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentDetailsManager
    {
        public List<StudentModel> DisplayResult(StudentModel studentmodel)
        {
            
            StudentDetailData studentData = new StudentDetailData();
            return studentData.GetStudentList(studentmodel);
        }
        public void UpdateData(StudentModel studentModel)
        {
            StudentDetailData studentData = new StudentDetailData();
            studentData.UpdateStudentData(studentModel);
        }
    }
}
