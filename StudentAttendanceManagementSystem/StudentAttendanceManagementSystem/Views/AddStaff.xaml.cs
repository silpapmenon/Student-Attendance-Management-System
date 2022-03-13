using BusinessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            pwdUsername.Text = String.Empty;
            txtgender.Text = String.Empty;
            txtstandard.Text = String.Empty;
        }



        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            id = (grdProductData.SelectedItem as StaffModel).StaffID;
            //txtstaffID.Text= (grdProductData.SelectedItem as StaffModel).StaffID.ToString();
            txtstandard.Text=(grdProductData.SelectedItem as StaffModel).Standard.ToString();
            txtStaffName.Text = (grdProductData.SelectedItem as StaffModel).StaffName.ToString();
            txtEmail.Text = (grdProductData.SelectedItem as StaffModel).StaffEmail.ToString();
            txtStaffMobile.Text = (grdProductData.SelectedItem as StaffModel).StaffMobile.ToString();
            txtqualification.Text= (grdProductData.SelectedItem as StaffModel).Qualification.ToString();
            txtAddress.Text = (grdProductData.SelectedItem as StaffModel).StaffAddress.ToString();
            txtCity.Text= (grdProductData.SelectedItem as StaffModel).StaffCity.ToString();
            txtPincode.Text= (grdProductData.SelectedItem as StaffModel).StaffPincode.ToString();
            txtUsername.Text= (grdProductData.SelectedItem as StaffModel).StaffUserName.ToString();
            pwdUsername.Text= (grdProductData.SelectedItem as StaffModel).StaffPassword.ToString();
            txtgender.Text= (grdProductData.SelectedItem as StaffModel).StaffGender.ToString();
            Refresh();
            

         }
        


        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            StaffModel staffModel = new StaffModel();
            staffModel.StaffID = id;
            staffModel.Standard = txtstandard.Text;
            
            staffModel.StaffName = txtStaffName.Text;
            staffModel.StaffEmail = txtEmail.Text;
            staffModel.StaffMobile = txtStaffMobile.Text;
            staffModel.Qualification = txtqualification.Text;
            staffModel.StaffAddress= txtAddress.Text;
            staffModel.StaffCity= txtCity.Text;
            staffModel.StaffPincode= txtPincode.Text;
            staffModel.StaffUserName = txtUsername.Text;
            staffModel.StaffPassword= pwdUsername.Text;
            staffModel.StaffGender = txtgender.Text;
            StaffManager staffManager=new StaffManager();
            staffManager.UpdateData(staffModel);
            MessageBox.Show("Edited");
            Refresh();
            ClearTextBox();
            
            

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
                    staffModel.StaffID=value;
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
            catch(Exception ex)
            {
             MessageBox.Show(ex.ToString());
            }
        }
        
        

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StaffManager staffManager= new StaffManager();
            StaffModel staffModel=new StaffModel();
            string StaffName = txtStaffName.Text;
            string Email =txtEmail.Text;
            string Mobile =txtStaffMobile.Text;
            //string Image =txt;
            string Qualification = txtqualification.Text;
            string Address=txtAddress.Text;
            string City=txtCity.Text;
            string Pincode=txtPincode.Text;
            string UserName=txtUsername.Text;
            string Password=pwdUsername.Text;
            string Gender=txtgender.Text;
            string Standard=txtstandard.Text;
            staffModel.Standard=Standard;
            staffModel.StaffName=StaffName;
            staffModel.StaffEmail=Email;
            staffModel.Qualification=Qualification;
            staffModel.StaffGender=Gender;
            staffModel.StaffAddress=Address;
            staffModel.StaffCity=City;
            staffModel.StaffUserName=UserName;
            staffModel.StaffPincode=Pincode;
            staffModel.StaffPassword=Password;
            staffModel.StaffMobile=Mobile;
            staffManager.SaveStaffDetails(staffModel);
            MessageBox.Show("Value Inserted");
            Refresh();
            ClearTextBox();

            
            
            
        }
    }
}
