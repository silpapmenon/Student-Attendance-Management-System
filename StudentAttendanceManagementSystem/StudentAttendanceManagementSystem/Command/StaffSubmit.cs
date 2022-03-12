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
    public class StaffSubmit :ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddStaffViewModel addStaffViewModel { get; set; }
        public StaffSubmit(AddStaffViewModel addStaffView)
        {
            addStaffViewModel = addStaffView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StaffModel staff = new StaffModel();
           // staff.StaffID = addStaffViewModel.StaffID;
            staff.Standard=addStaffViewModel.Standard;
            staff.StaffName = addStaffViewModel.StaffName;
            staff.StaffEmail = addStaffViewModel.StaffEmail;
            staff.StaffMobile = addStaffViewModel.StaffMobile;
            staff.StaffImage = addStaffViewModel.Image;
            staff.Qualification = addStaffViewModel.Qualification;
            staff.StaffAddress = addStaffViewModel.StaffAddress;
            staff.StaffCity = addStaffViewModel.StaffCity;
            staff.StaffPincode = addStaffViewModel.StaffPincode;
            staff.StaffUserName = addStaffViewModel.StaffUsername;
            staff.StaffPassword = addStaffViewModel.StaffPassword;
            staff.StaffGender = addStaffViewModel.Gender;
            staff.RoleID = addStaffViewModel.RoleID;
            StaffManager staffManager = new StaffManager();
            staffManager.SaveStaffDetails(staff);

        }
    }
}

