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
    public class AddStaffViewModel :BaseViewModel
    {
        private StaffModel _staffModel;
        private List<StaffModel> _staffViewList;
        public List<StaffModel> StaffViewList { get => _staffViewList; set => _staffViewList = value; }

        public StaffManager staffManager = new StaffManager();
        public AddStaffViewModel(StaffModel staff)
        {
            _staffModel = staff;
            StaffViewList = staffManager.DisplayResult();
            Submit = new StaffSubmit(this);
           
        }
       
        private int _staffID;
        private string _staffName;
        private string _staffEmail;
        private string _staffMobile;
        private string _staffImage;
        private string _qualification;
        private string _staffAddress;
        private string _staffCity;
        private string _staffPincode;
        private string _staffUsername;
        private string _staffPassword;
        private string _staffGender;
        private int _roleID;

        public int StaffID
        {
            get { return _staffID; }
            set
            {
                _staffID = value;
                OnPropertyChanged("StaffID");
            }
        }
        public string StaffName
        {
            get { return _staffName; }
            set
            {
                _staffName = value;
                OnPropertyChanged(" StaffName");
            }
        }
        public string StaffEmail
        {
            get { return _staffEmail; }
            set
            {
                _staffEmail = value;
                OnPropertyChanged("StaffEmail");
            }
        }
        public string StaffMobile
        {
            get { return _staffMobile; }
            set
            {
                _staffMobile = value;
                OnPropertyChanged("StaffMobile");
            }
        }
        public string Image
        {
            get { return _staffImage; }
            set
            {
                _staffImage = value;
                OnPropertyChanged("Image");
            }
        }
        public string Qualification
        {
            get { return _qualification; }
            set
            {
                _qualification = value;
                OnPropertyChanged("Qualification");
            }
        }

        public string StaffAddress
        {
            get { return _staffAddress; }
            set
            {
                _staffAddress = value;
                OnPropertyChanged("StudentAddress");
            }
        }
        public string StaffCity
        {
            get { return _staffCity; }
            set
            {
                _staffCity = value;
                OnPropertyChanged("StaffCity");
            }
        }
        public string StaffPincode
        {
            get { return _staffPincode; }
            set
            {
                _staffPincode = value;
                OnPropertyChanged("StaffPincode");
            }
        }
        public string StaffUsername
        {
            get { return _staffUsername; }
            set
            {
                _staffUsername = value;
                OnPropertyChanged("StaffUsername");
            }
        }
        public string StaffPassword
        {
            get { return _staffPassword; }
            set
            {
                _staffPassword = value;
                OnPropertyChanged("StaffPassword");
            }
        }
        public string Gender
        {
            get { return _staffGender; }
            set
            {
                _staffGender = value;
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

