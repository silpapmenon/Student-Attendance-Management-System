using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentReportBusinessModel
    {
        public List<StudentModel> DisplayResult()
        {
            StudentData studentData = new StudentData();
            return studentData.GetStudentList();
        }
    }
}
