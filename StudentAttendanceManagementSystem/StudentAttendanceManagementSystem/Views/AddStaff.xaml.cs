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
    /// Interaction logic for AddStaff.xaml
    /// </summary>
    public partial class AddStaff : UserControl
    {
        public int id;
        public AddStaff()
        {
            InitializeComponent();
            this.DataContext = new AddStaffViewModel();
            Refresh();
        }


































        void Refresh()
        {
            StaffManager staffManager = new StaffManager();
            grdProductData.ItemsSource = staffManager.DisplayResult();
        }
        void ClearTextBox()
        {
            txtStaffName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtStaffMobile.Text = String.Empty;
            txtqualification.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtPincode.Text = String.Empty;
            txtUsername.Text = String.Empty;
            pwdUsername.Password = String.Empty;
            txtgender.Text = String.Empty;
            txtstandard.Text = String.Empty;
        }



        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            txtid.Text = (grdProductData.SelectedItem as StaffModel).StaffID.ToString();
            //txtstaffID.Text= (grdProductData.SelectedItem as StaffModel).StaffID.ToString();
            txtstandard.Text = (grdProductData.SelectedItem as StaffModel).Standard.ToString();
            txtStaffName.Text = (grdProductData.SelectedItem as StaffModel).StaffName.ToString();
            txtEmail.Text = (grdProductData.SelectedItem as StaffModel).StaffEmail.ToString();
            txtStaffMobile.Text = (grdProductData.SelectedItem as StaffModel).StaffMobile.ToString();
            txtqualification.Text = (grdProductData.SelectedItem as StaffModel).Qualification.ToString();
            txtAddress.Text = (grdProductData.SelectedItem as StaffModel).StaffAddress.ToString();
            txtCity.Text = (grdProductData.SelectedItem as StaffModel).StaffCity.ToString();
            txtPincode.Text = (grdProductData.SelectedItem as StaffModel).StaffPincode.ToString();
            txtUsername.Text = (grdProductData.SelectedItem as StaffModel).StaffUserName.ToString();
            pwdUsername.Password = (grdProductData.SelectedItem as StaffModel).StaffPassword.ToString();
            txtgender.Text = (grdProductData.SelectedItem as StaffModel).StaffGender.ToString();
            Refresh();


        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdProductData.Items.Count > 0)
                {
                    var value = (grdProductData.SelectedItem as StaffModel).StaffID;
                    StaffModel staffModel = new StaffModel();
                    StaffManager staffManager = new StaffManager();
                    staffModel.StaffID = value;
                    staffManager.DeleteStaffDetails(staffModel);
                    MessageBox.Show("Deleted");
                    Refresh();
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("No ID Found");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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