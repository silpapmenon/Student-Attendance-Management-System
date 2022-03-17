using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class SubmitCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public string Passwords { get; set; }
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

            if (parameter.ToString() == "Update")
            {

            }
            else
            {
                if (addStudentViewModel.StudentID == 0)
                {
                    PasswordBox boxpass = (PasswordBox)parameter;
                    Passwords = boxpass.Password;
                    string RollNo = addStudentViewModel.RollNo.ToString();
                    string StudentName = addStudentViewModel.StudentName;
                    string StudentAddress = addStudentViewModel.StudentAddress;
                    string DivisionName = addStudentViewModel.DivisionName;
                    string StudentEmail = addStudentViewModel.StudentEmail;
                    string StudentMobile = addStudentViewModel.StudentMobile;
                    string DOB = addStudentViewModel.DOB.ToString();
                    //student.Image = addStudentViewModel.Image;
                    string StudentCity = addStudentViewModel.StudentCity;
                    string Studentpincode = addStudentViewModel.StudentPincode.ToString();
                    string Studentusername = addStudentViewModel.StudentUsername;
                    string Studentpassword = Passwords;
                    string GenderName = addStudentViewModel.GenderName;
                    string StandardName = addStudentViewModel.StandardName;

                    if (!string.IsNullOrEmpty(RollNo) && !string.IsNullOrEmpty(StudentName)
                        && !string.IsNullOrEmpty(DOB) && !string.IsNullOrEmpty(Studentusername) && !string.IsNullOrEmpty(Studentpassword)
                        && !string.IsNullOrEmpty(GenderName) && !string.IsNullOrEmpty(StudentEmail) && !string.IsNullOrEmpty(Studentpincode)
                        && !string.IsNullOrEmpty(StudentAddress) && !string.IsNullOrEmpty(StudentMobile) && !string.IsNullOrEmpty(StudentCity)
                        && !string.IsNullOrEmpty(DivisionName) && !string.IsNullOrEmpty(StandardName))
                    {
                        if (!int.TryParse(RollNo, out _))
                        {
                            MessageBox.Show("RollNo should be a number");
                        }
                        else
                        {
                            if (!int.TryParse(Studentpincode, out _))
                            {
                                MessageBox.Show("Pincode should be a number");
                            }
                            else
                            {
                                if (!isValidPhoneNumber(StudentMobile))
                                {
                                    MessageBox.Show("Invalid Mobile number");
                                }
                                if (Convert.ToDateTime(DOB) >= DateTime.Now)
                                {
                                    MessageBox.Show("Oops, you haven't been born yet!");
                                }
                                else
                                {
                                    if (StudentMobile.Count() == 10)
                                    {
                                        if (!isValidEmail(StudentEmail))
                                        {
                                            MessageBox.Show("Invalid Email ID");
                                        }
                                        else
                                        {
                                           
                                            StudentModel student = new StudentModel();
                                            student.RollNo = addStudentViewModel.RollNo;
                                            student.StudentName = addStudentViewModel.StudentName;
                                            student.StudentAddress = addStudentViewModel.StudentAddress;
                                            student.DivisionName = addStudentViewModel.DivisionName;
                                            student.StudentEmail = addStudentViewModel.StudentEmail;
                                            student.StudentMobile = addStudentViewModel.StudentMobile;
                                            student.DOB = addStudentViewModel.DOB;
                                            //student.Image = addStudentViewModel.Image;
                                            student.StudentCity = addStudentViewModel.StudentCity;
                                            student.Studentpincode = addStudentViewModel.StudentPincode;
                                            student.Studentusername = addStudentViewModel.StudentUsername;
                                            student.Studentpassword = Passwords;
                                            student.GenderName = addStudentViewModel.GenderName;
                                            student.StandardName = addStudentViewModel.StandardName;
                                            student.RoleID = 3;
                                            student.StandardName = addStudentViewModel.StandardName;
                                            StudentManager studentManager = new StudentManager();
                                            studentManager.SaveStudentDetails(student);
                                        }

                                    }

                                }
                            }
                        }
                    }


                    else
                    {
                        MessageBox.Show(" Enter all Fields ");
                    }
                }

                else
                {
                    PasswordBox boxpass = (PasswordBox)parameter;
                    Passwords = boxpass.Password;
                    string studentid = addStudentViewModel.StudentID.ToString();
                    string RollNo = addStudentViewModel.RollNo.ToString();
                    string StudentName = addStudentViewModel.StudentName;
                    string StudentAddress = addStudentViewModel.StudentAddress;
                    string DivisionName = addStudentViewModel.DivisionName;
                    string StudentEmail = addStudentViewModel.StudentEmail;
                    string StudentMobile = addStudentViewModel.StudentMobile;
                    string DOB = addStudentViewModel.DOB.ToString();
                    //student.Image = addStudentViewModel.Image;
                    string StudentCity = addStudentViewModel.StudentCity;
                    string Studentpincode = addStudentViewModel.StudentPincode.ToString();
                    string Studentusername = addStudentViewModel.StudentUsername;
                    string Studentpassword = Passwords;
                    string GenderName = addStudentViewModel.GenderName;
                    string StandardName = addStudentViewModel.StandardName;

                    if (!string.IsNullOrEmpty(studentid) && !string.IsNullOrEmpty(RollNo) && !string.IsNullOrEmpty(StudentName)
                        && !string.IsNullOrEmpty(DOB) && !string.IsNullOrEmpty(Studentusername) && !string.IsNullOrEmpty(Studentpassword)
                        && !string.IsNullOrEmpty(GenderName) && !string.IsNullOrEmpty(StudentEmail) && !string.IsNullOrEmpty(Studentpincode)
                        && !string.IsNullOrEmpty(StudentAddress) && !string.IsNullOrEmpty(StudentMobile) && !string.IsNullOrEmpty(StudentCity)
                        && !string.IsNullOrEmpty(DivisionName) && !string.IsNullOrEmpty(StandardName))
                    {
                        if (!int.TryParse(RollNo, out _))
                        {
                            MessageBox.Show("RollNo should be a number");
                        }
                        else
                        {
                            if (!int.TryParse(Studentpincode, out _))
                            {
                                MessageBox.Show("Pincode should be a number");
                            }
                            else
                            {
                                if (!isValidPhoneNumber(StudentMobile))
                                {
                                    MessageBox.Show("Invalid Mobile number");
                                }
                                if (Convert.ToDateTime(DOB) >= DateTime.Now)
                                {
                                    MessageBox.Show("Oops, you haven't been born yet!");
                                }
                                else
                                {
                                    if (StudentMobile.Count() == 10)
                                    {
                                        if (!isValidEmail(StudentEmail))
                                        {
                                            MessageBox.Show("Invalid Email ID");
                                        }
                                        else
                                        {
                                            
                                            StudentModel student = new StudentModel();
                                            student.StudentID = addStudentViewModel.StudentID;
                                            student.RollNo = addStudentViewModel.RollNo;
                                            student.StudentName = addStudentViewModel.StudentName;
                                            student.StudentAddress = addStudentViewModel.StudentAddress;
                                            student.DivisionName = addStudentViewModel.DivisionName;
                                            student.StudentEmail = addStudentViewModel.StudentEmail;
                                            student.StudentMobile = addStudentViewModel.StudentMobile;
                                            student.DOB = addStudentViewModel.DOB;
                                            //student.Image = addStudentViewModel.Image;
                                            student.StudentCity = addStudentViewModel.StudentCity;
                                            student.Studentpincode = addStudentViewModel.StudentPincode;
                                            student.Studentusername = addStudentViewModel.StudentUsername;
                                            student.Studentpassword = Passwords;
                                            student.GenderName = addStudentViewModel.GenderName;
                                            student.StandardName = addStudentViewModel.StandardName;
                                            student.RoleID = 3;
                                            student.StandardName = addStudentViewModel.StandardName;
                                            StudentManager studentManager = new StudentManager();
                                            studentManager.UpdateData(student);
                                        }

                                    }

                                }
                            }
                        }
                    }


                    else
                    {
                        MessageBox.Show(" Enter all Fields ");
                    }

                    
                }

            }

        }
        public static string Protect(string str)
        {
            byte[] entropy = Encoding.ASCII.GetBytes(Assembly.GetExecutingAssembly().FullName);
            byte[] data = Encoding.ASCII.GetBytes(str);
            string protectedData = Convert.ToBase64String(ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser));
            return protectedData;
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
        public static bool isValidPhoneNumber(string StudentMobile)
        {
            string strRegex = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(StudentMobile))
                return (true);
            else
                return (false);
        }

    }
}
