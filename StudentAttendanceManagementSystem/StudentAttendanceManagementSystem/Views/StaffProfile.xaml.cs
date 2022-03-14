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
    /// Interaction logic for StaffProfile.xaml
    /// </summary>
    public partial class StaffProfile : UserControl
    {
        StaffModel staffModels = new StaffModel();
        public StaffProfile(StaffModel staffModel)
        {
            InitializeComponent();
            staffModels = staffModel;
            //Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            txtName1.Text = (grdstaffdetail.SelectedItem as StudentModel).StudentName;
           
            txtUsername.Text = (grdstaffdetail.SelectedItem as StaffModel).StaffUserName;
            txtPassword.Password = (grdstaffdetail.SelectedItem as StaffModel).StaffPassword;
            //gender.Text = (grdstuds.SelectedItem as StudentModel).GenderName;
            txtEmail.Text = (grdstaffdetail.SelectedItem as StaffModel).StaffEmail;
            txtPincode.Text = (grdstaffdetail.SelectedItem as StaffModel).StaffPincode;
            txtAddress.Text = (grdstaffdetail.SelectedItem as StaffModel).StaffAddress;
            txtMobile.Text = (grdstaffdetail.SelectedItem as StaffModel).StaffMobile;
            txtCity.Text = (grdstaffdetail.SelectedItem as StaffModel).StaffCity;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string StaffName = txtName1.Text;
            string StaffUsername = txtUsername.Text;
            string Staffpassword = txtPassword.Password;
            string StaffEmail = txtEmail.Text;
            string StaffPincode = txtPincode.Text;
            string StaffAddress = txtAddress.Text;
            string StaffMobile = txtMobile.Text;
            string StaffCity = txtCity.Text;
            // string DivisionName = div.Text;
            // string StandardName = standard.Text;
            if (!string.IsNullOrEmpty(StaffName)
                 && !string.IsNullOrEmpty(StaffUsername) && !string.IsNullOrEmpty(Staffpassword)
                && !string.IsNullOrEmpty(StaffEmail) && !string.IsNullOrEmpty(StaffPincode)
                && !string.IsNullOrEmpty(StaffAddress) && !string.IsNullOrEmpty(StaffMobile) && !string.IsNullOrEmpty(StaffCity)
                )
            {
                if (!int.TryParse(StaffPincode, out _))
                {
                    MessageBox.Show("Pincode should be a number");
                }
                else
                {
                    if (!isValidPhoneNumber(StaffMobile))
                    {
                        MessageBox.Show("Invalid Phone Number");
                    }
                    else
                    {
                        if (StaffMobile.Count() == 10)
                        {
                            if (!isValidEmail(StaffEmail))
                            {
                                MessageBox.Show("Invalid Email ID");
                            }
                            else
                            {
                                StaffDetailsBusiness sdm = new StaffDetailsBusiness();
                                StaffModel staffModels = new StaffModel();


                                staffModels.StaffName = txtName1.Text;

                                staffModels.StaffUserName = txtUsername.Text;
                                staffModels.StaffPassword = txtPassword.Password;

                                staffModels.StaffEmail = txtEmail.Text;
                                staffModels.StaffPincode = txtPincode.Text;
                                staffModels.StaffAddress = txtAddress.Text;
                                staffModels.StaffMobile = txtMobile.Text;
                                staffModels.StaffCity = txtCity.Text;

                                StaffDetailsBusiness staffDetailsBusiness = new StaffDetailsBusiness();
                                staffDetailsBusiness.UpdateStaffData(staffModels);
                                MessageBox.Show("Student Details Edited");
                                //Refresh();
                                //txtid.Text = String.Empty;
                                // grdstuds.ItemsSource = sdm.DisplayResult(s);

                                //ClearTextBox();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Mobile Number should be 10 digits");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter All Fields");
            }

            void Refresh()
            {
                StaffDetailsBusiness staffDetailsBusiness = new StaffDetailsBusiness();
                grdstaffdetail.ItemsSource = staffDetailsBusiness.GetAllDetails(staffModels);
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

        private void grdstaffdetail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        void Refresh()
        {
            StaffModel model = new StaffModel();
            model = staffModels;
            StaffDetailsBusiness sdm = new StaffDetailsBusiness();
            grdstaffdetail.ItemsSource = sdm.GetAllDetails(staffModels);
        }
        void ClearTextBox()
        {
            
            txtName1.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtMobile.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtPincode.Text = String.Empty;
            txtUsername.Text = String.Empty;
            txtPassword.Password = String.Empty;
            
            
        }
    }
}

