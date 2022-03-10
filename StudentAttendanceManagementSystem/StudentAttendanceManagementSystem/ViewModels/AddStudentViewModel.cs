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
    public class AddStudentViewModel : BaseViewModel
    {

        private StudentModel _studentModel;
        private List<StudentModel> _studentViewList;
        public List<StudentModel> StudentViewList { get => _studentViewList; set => _studentViewList = value; }

        public StudentManager studentManager = new StudentManager();
        public AddStudentViewModel(StudentModel student)
        {
            _studentModel = student;
            StudentViewList = studentManager.DisplayResult();
            Submit = new SubmitCommand(this);
        }
        private int _studentID;
        private int _rollNo;
        private string _studentName;
        private string _divisionName;
        private string _email;
        private string _studentMobile;
        private DateTime _dob = DateTime.Now;
        private string _image;
        private string _studentAddress;
        private string _studentCity;
        private int _studentPincode;
        private string _studentUsername;
        private string _studentPassword;
        private int _standardID;
        private int _gender;
        private int _roleID;
        private string _standardName;
        private string _genderName;

        public string StandardName
        {
            get { return _standardName; }
            set
            {
                _standardName = value;
                OnPropertyChanged("StandardName");
            }
        }
        public string GenderName
        {
            get { return _genderName; }
            set
            {
                _genderName = value;
                OnPropertyChanged("GenderName");
            }
        }
        public int StudentID
        {
            get { return _studentID; }
            set
            {
                _studentID = value;
                OnPropertyChanged("StudentID");
            }
        }
        public int RollNo
        {
            get { return _rollNo; }
            set
            {
                _rollNo = value;
                OnPropertyChanged("RollNo");
            }
        }
        public string StudentName
        {
            get { return _studentName; }
            set
            {
                _studentName = value;
                OnPropertyChanged(" StudentName");
            }
        }
        public string DivisionName
        {
            get { return _divisionName; }
            set
            {
                _divisionName = value;
                OnPropertyChanged("DivisionName");
            }
        }
        public string StudentEmail
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("StudentEmail");
            }
        }
        public string StudentMobile
        {
            get { return _studentMobile; }
            set
            {
                _studentMobile = value;
                OnPropertyChanged("StudentMobile");
            }
        }
        public DateTime DOB
        {
            get { return _dob; }
            set
            {
                _dob = value;
                OnPropertyChanged("DOB");
            }
        }
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged("Image");
            }
        }
        public string StudentAddress
        {
            get { return _studentAddress; }
            set
            {
                _studentAddress = value;
                OnPropertyChanged("StudentAddress");
            }
        }
        public string StudentCity
        {
            get { return _studentCity; }
            set
            {
                _studentCity = value;
                OnPropertyChanged("StudentCity");
            }
        }
        public int StudentPincode
        {
            get { return _studentPincode; }
            set
            {
                _studentPincode = value;
                OnPropertyChanged("StudentPincode");
            }
        }
        public string StudentUsername
        {
            get { return _studentUsername; }
            set
            {
                _studentUsername = value;
                OnPropertyChanged("StudentUsername");
            }
        }
        public string StudentPassword
        {
            get { return _studentPassword; }
            set
            {
                _studentPassword = value;
                OnPropertyChanged("StudentPassword");
            }
        }
        public int StandardID
        {
            get { return _standardID; }
            set
            {
                _standardID = value;
                OnPropertyChanged("StandardID");
            }
        }
        public int Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public int RoleID
        {
            get { return _roleID; }
            set
            {
                _roleID = value;
                OnPropertyChanged("RoleID");
            }
        }
        public ICommand Submit { get; set; }
    }
}

