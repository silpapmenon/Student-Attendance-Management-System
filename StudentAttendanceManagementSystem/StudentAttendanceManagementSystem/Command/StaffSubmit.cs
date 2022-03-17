using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class StaffSubmit : ICommand
    {
        public string Passwords { get; set; }
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
            if (addStaffViewModel.StaffID == 0)
            {

                PasswordBox boxpass = (PasswordBox)parameter;
                Passwords = boxpass.Password;
                //staff.StaffID = addStaffViewModel.StaffID;
                string Standard = addStaffViewModel.Standard;
                string StaffName = addStaffViewModel.StaffName;
                string Email = addStaffViewModel.StaffEmail;
                string Mobile = addStaffViewModel.StaffMobile;
                //staff.StaffImage = addStaffViewModel.Image;
                string Qualification = addStaffViewModel.Qualification;
                string Address = addStaffViewModel.StaffAddress;
                string City = addStaffViewModel.StaffCity;
                string Pincode = addStaffViewModel.StaffPincode;
                string UserName = addStaffViewModel.StaffUsername;
                string Password = Passwords;
                string Gender = addStaffViewModel.Gender;
                if (!string.IsNullOrEmpty(StaffName) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Mobile)
                    && !string.IsNullOrEmpty(Qualification) && !string.IsNullOrEmpty(Address)
                    && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(Pincode) && !string.IsNullOrEmpty(UserName)
                    && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Standard))
                {
                    if (!int.TryParse(Pincode, out _))
                    {
                        MessageBox.Show("Pincode should be a number");
                    }
                    else
                    {
                        if (!isValidPhoneNumber(Mobile))
                        {
                            MessageBox.Show("Invalid Phone Number");
                        }
                        else
                        {
                            if (Mobile.Count() == 10)
                            {
                                if (!isValidEmail(Email))
                                {
                                    MessageBox.Show("Invalid Email ID");
                                }
                                else
                                {

                                    StaffModel staff = new StaffModel();
                                    //staff.StaffID = addStaffViewModel.StaffID;
                                    staff.Standard = addStaffViewModel.Standard;
                                    staff.StaffName = addStaffViewModel.StaffName;
                                    staff.StaffEmail = addStaffViewModel.StaffEmail;
                                    staff.StaffMobile = addStaffViewModel.StaffMobile;
                                    //staff.StaffImage = addStaffViewModel.Image;
                                    staff.Qualification = addStaffViewModel.Qualification;
                                    staff.StaffAddress = addStaffViewModel.StaffAddress;
                                    staff.StaffCity = addStaffViewModel.StaffCity;
                                    staff.StaffPincode = addStaffViewModel.StaffPincode;
                                    staff.StaffUserName = addStaffViewModel.StaffUsername;
                                    staff.StaffPassword = Passwords;
                                    staff.StaffGender = addStaffViewModel.Gender;
                                    staff.RoleID = 2;
                                    StaffManager staffManager = new StaffManager();
                                    staffManager.SaveStaffDetails(staff);
                                    MessageBox.Show("Added Succesfully");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mobile Number Should be 10 Digit");

                            }
                        }

                    }
                }
            }
            else
            {
                PasswordBox boxpass = (PasswordBox)parameter;
                Passwords = boxpass.Password;
                string StaffID = addStaffViewModel.StaffID.ToString();
                string Standard = addStaffViewModel.Standard;
                string StaffName = addStaffViewModel.StaffName;
                string Email = addStaffViewModel.StaffEmail;
                string Mobile = addStaffViewModel.StaffMobile;
                //staff.StaffImage = addStaffViewModel.Image;
                string Qualification = addStaffViewModel.Qualification;
                string Address = addStaffViewModel.StaffAddress;
                string City = addStaffViewModel.StaffCity;
                string Pincode = addStaffViewModel.StaffPincode;
                string UserName = addStaffViewModel.StaffUsername;
                string Password = Passwords;
                string Gender = addStaffViewModel.Gender;
                if (!string.IsNullOrEmpty(StaffID) && !string.IsNullOrEmpty(StaffName) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Mobile)
                    && !string.IsNullOrEmpty(Qualification) && !string.IsNullOrEmpty(Address)
                    && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(Pincode) && !string.IsNullOrEmpty(UserName)
                    && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Standard))
                {
                    if (!int.TryParse(Pincode, out _))
                    {
                        MessageBox.Show("Pincode should be a number");
                    }
                    else
                    {
                        if (!isValidPhoneNumber(Mobile))
                        {
                            MessageBox.Show("Invalid Phone Number");
                        }
                        else
                        {
                            if (Mobile.Count() == 10)
                            {
                                if (!isValidEmail(Email))
                                {
                                    MessageBox.Show("Invalid Email ID");
                                }
                                else
                                {

                                    StaffModel staff = new StaffModel();
                                    staff.StaffID = addStaffViewModel.StaffID;
                                    staff.Standard = addStaffViewModel.Standard;
                                    staff.StaffName = addStaffViewModel.StaffName;
                                    staff.StaffEmail = addStaffViewModel.StaffEmail;
                                    staff.StaffMobile = addStaffViewModel.StaffMobile;
                                    //staff.StaffImage = addStaffViewModel.Image;
                                    staff.Qualification = addStaffViewModel.Qualification;
                                    staff.StaffAddress = addStaffViewModel.StaffAddress;
                                    staff.StaffCity = addStaffViewModel.StaffCity;
                                    staff.StaffPincode = addStaffViewModel.StaffPincode;
                                    staff.StaffUserName = addStaffViewModel.StaffUsername;
                                    staff.StaffPassword = Passwords;
                                    staff.StaffGender = addStaffViewModel.Gender;
                                    StaffManager staffManager = new StaffManager();
                                    staffManager.UpdateData(staff);
                                    MessageBox.Show("Updated");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mobile Number Should be 10 Digit");

                            }
                        }

                    }
                }
            }


        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static bool isValidPhoneNumber(string PhoneNumber)
        {
            string strRegex = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(PhoneNumber))
                return (true);
            else
                return (false);
        }

    }

}

