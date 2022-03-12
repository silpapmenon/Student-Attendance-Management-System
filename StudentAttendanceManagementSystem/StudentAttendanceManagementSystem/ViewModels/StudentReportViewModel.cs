using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class StudentReportViewModel :BaseViewModel
    {
        public ICommand Submit { get; set; }
        
        private StudentModel _studentReport;
        public List<StudentModel> StudentReport { get; set ; } 

        public StudentReportBusinessModel studentReport = new StudentReportBusinessModel();
        public StudentReportViewModel(StudentModel student) 
        {        
            StudentReport = new List<StudentModel>();
            StudentReportBusinessModel objbusiness = new StudentReportBusinessModel();
            StudentReport = objbusiness.DisplayResult();
        }   
    }
}
