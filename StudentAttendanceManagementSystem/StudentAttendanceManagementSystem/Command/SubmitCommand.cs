using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class SubmitCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddStudentViewModel addStudentViewModel { get; set; }
        public SubmitCommand(AddStudentViewModel addStudentView)
        {
            addStudentViewModel = addStudentView;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            //StudentModel  student = new StudentModel();
            //student.RollNo = addStudentViewModel.RollNo;
            //student.StudentName = addStudentViewModel.StudentName;
            //student.StudentAddress = addStudentViewModel.StudentAddress;
            //student.DivisionName = addStudentViewModel.DivisionName;
            //student.StudentEmail = addStudentViewModel.StudentEmail;
            //student.StudentMobile = addStudentViewModel.StudentMobile;
            //student.DOB = addStudentViewModel.DOB;
            //student.Image= addStudentViewModel.Image; 
            //student.StudentCity = addStudentViewModel.StudentCity;
            //student.Studentpincode = addStudentViewModel.StudentPincode;
            //student.Studentusername = addStudentViewModel.StudentUsername;
            //student.Studentpassword = addStudentViewModel.StudentPassword;
            //student.Gender = addStudentViewModel.Gender;
            //student.GenderName = addStudentViewModel.GenderName;
            //student.StandardID = addStudentViewModel.StandardID;
            //student.StudentID = addStudentViewModel.StudentID;
            //student.RoleID = addStudentViewModel.RoleID;
            //student.StandardName= addStudentViewModel.StandardName;
            //StudentManager studentManager = new StudentManager();
            //studentManager.SaveStudentDetails(student);
        }
    }
}
