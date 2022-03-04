using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class StudentModel
    {
        private int _studentID;   
        private string _studentName;
        private string _divisionName;
        private string _email; 
        private int _studentMobile;
        private DateTime _dob;
        private string _image;
        private string _studentAddress;
        private string _studentCity;
        private int _studentPincode;
        private string _studentUsername;
        private string _studentPassword;
        private int _standardID;
        private string _gender;
        private int _roleID;
        public int StudentID { get => _studentID; set => _studentID = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string DivisionName { get => _divisionName; set => _divisionName = value; }
        public string Email { get => _email; set => _email = value; }
        public int StudentMobile { get => _studentMobile; set => _studentMobile = value; }
        public DateTime DOB { get => _dob; set => _dob = value; }
        public string Image { get => _image; set => _image = value; }
        public string StudentAddress { get => _studentAddress; set => _studentAddress = value; }
        public string StudentCity { get => _studentCity; set => _studentCity = value; }
        public int StudentPincode { get => _studentPincode; set => _studentPincode = value; }
        public string StudentUsername { get => _studentUsername; set => _studentUsername = value; }
        public string StudentPassword { get => _studentPassword; set => _studentPassword = value; }
        public int StandardID { get => _standardID; set => _standardID = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int RoleID { get => _roleID; set => _roleID = value; }
    }
    
}
