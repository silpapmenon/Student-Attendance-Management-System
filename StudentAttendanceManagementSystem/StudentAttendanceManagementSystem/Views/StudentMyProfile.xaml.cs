using BusinessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentAttendanceManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StudentMyProfile.xaml
    /// </summary>
    public partial class StudentMyProfile : UserControl
    {
        public StudentModel studentModel = new StudentModel();
        public int ID;
        public StudentMyProfile(StudentModel studentModels)
        {
            studentModel = studentModels;
            StudentDetailsManager studentDetailsManager = new StudentDetailsManager();
            
            InitializeComponent();
           grdstuds.ItemsSource = studentDetailsManager.DisplayResult(studentModels);
            //Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string StudentID = Convert.ToString( studentModel.StudentID);
            string RollNo = txtRollNo.Text;
            string StudentName = txtName1.Text;
            string DOB = dt.Text;
            string Studentusername = txtUsername.Text;
            string Studentpassword = password.Password;
            //string GenderName = gender.Text;
            string StudentEmail = txtEmail.Text;
            string Studentpincode = txtPincode.Text;
            string StudentAddress = txtAddress.Text;
            string StudentMobile = txtMobile.Text;
            string StudentCity = txtCity.Text;
            // string DivisionName = div.Text;
            // string StandardName = standard.Text;
            if (!string.IsNullOrEmpty(StudentID) && !string.IsNullOrEmpty(RollNo) && !string.IsNullOrEmpty(StudentName)
                && !string.IsNullOrEmpty(DOB) && !string.IsNullOrEmpty(Studentusername) && !string.IsNullOrEmpty(Studentpassword)
                && !string.IsNullOrEmpty(StudentEmail) && !string.IsNullOrEmpty(Studentpincode)
                && !string.IsNullOrEmpty(StudentAddress) && !string.IsNullOrEmpty(StudentMobile) && !string.IsNullOrEmpty(StudentCity)
                )
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
                        if (dt.SelectedDate > DateTime.Now)
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
                                    StudentDetailsManager sdm=new StudentDetailsManager();
                                    StudentModel studentModels = new StudentModel();
                                    studentModels.StudentID =  studentModel.StudentID;
                                    studentModels.RollNo = Convert.ToInt32(txtRollNo.Text);
                                    studentModels.StudentName = txtName1.Text;
                                    studentModels.DOB = Convert.ToDateTime(dt.Text);
                                    studentModels.Studentusername = txtUsername.Text;
                                    studentModels.Studentpassword = password.Password;
                                    //studentModels.GenderName = gender.Text;
                                    studentModels.StudentEmail = txtEmail.Text;
                                    studentModels.Studentpincode = Convert.ToInt32(txtPincode.Text);
                                    studentModels.StudentAddress = txtAddress.Text;
                                    studentModels.StudentMobile = txtMobile.Text;
                                    studentModels.StudentCity = txtCity.Text;
                                    //studentModel.Gender = gender.Text;
                                    //studentModel.DivisionName = div.Text;
                                    // studentModel.StandardName = standard.Text;
                                    StudentDetailsManager studentManager = new StudentDetailsManager();
                                    studentManager.UpdateData(studentModels);
                                     MessageBox.Show("Student Details Edited");
                                    Refresh();
                                    //txtid.Text = String.Empty;
                                   // grdstuds.ItemsSource = sdm.DisplayResult(s);

                                    ClearTextBox();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Mobile Number should be 10 digits");
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtRollNo.Text = (grdstuds.SelectedItem as StudentModel).RollNo.ToString();
            txtName1.Text = (grdstuds.SelectedItem as StudentModel).StudentName;
            dt.Text = (grdstuds.SelectedItem as StudentModel).DOB.ToString();
            txtUsername.Text = (grdstuds.SelectedItem as StudentModel).Studentusername;
            password.Password = (grdstuds.SelectedItem as StudentModel).Studentpassword;
            //gender.Text = (grdstuds.SelectedItem as StudentModel).GenderName;
            txtEmail.Text = (grdstuds.SelectedItem as StudentModel).StudentEmail;
            txtPincode.Text = (grdstuds.SelectedItem as StudentModel).Studentpincode.ToString();
            txtAddress.Text = (grdstuds.SelectedItem as StudentModel).StudentAddress;
            txtMobile.Text = (grdstuds.SelectedItem as StudentModel).StudentMobile.ToString();
            txtCity.Text = (grdstuds.SelectedItem as StudentModel).StudentCity;
        }

        private void grdstud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //gender.Text = (grdProductData.SelectedItem as StudentModel).GenderName;
            // div.Text = (grdstud.SelectedItem as StudentModel).DivisionName;
            //standard.Text = (grdstud.SelectedItem as StudentModel).StandardName;
           // Refresh();
        }

        void Refresh()
        {
            StudentModel model = new StudentModel();
            model = studentModel;
            StudentDetailsManager studentDetailsManager = new StudentDetailsManager();
            grdstuds.ItemsSource = studentDetailsManager.DisplayResult(studentModel);
        }
        void ClearTextBox()
        {
            txtRollNo.Text = String.Empty;
            txtName1.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtMobile.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtPincode.Text = String.Empty;
            txtUsername.Text = String.Empty;
            password.Password = String.Empty;
            //div.Text = String.Empty;
            //gender.Text = String.Empty;
            //standard.Text = String.Empty;
            dt.Text = String.Empty;
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


