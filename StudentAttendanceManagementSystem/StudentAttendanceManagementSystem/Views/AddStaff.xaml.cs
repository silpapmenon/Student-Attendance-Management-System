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

        private void grdProductData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    btnAdd.Content = "Edit";
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            id = (grdProductData.SelectedItem as StaffModel).StaffID;
            txtstaffID.Text= (grdProductData.SelectedItem as StaffModel).StaffID.ToString();
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



            //Refresh();

            //btnAdd.Content = "Edit";

            //    StaffModel staffModel = new StaffModel();
            //    string name = txtProductName.Text;
            //    string description = txtProductDescription.Text;
            //    Products product = new Products();
            //    if (name != null && description != null && txtProductDescription.Text.ToString() != null && txtProductUnit.Text.ToString() != null)
            //    {
            //        productModel.ProductName = name;
            //        productModel.ProductDescription = description;
            //        productModel.ProductPrice = float.Parse(txtProductPrice.Text);
            //        productModel.ProductUnit = Int32.Parse(txtProductUnit.Text);
            //        product.SaveData(productModel);
            //        MessageBox.Show("Product Added");
            //        Refresh();
            //        ClearTextBox();
            //    }
            //    else
            //        MessageBox.Show("Enter all Values");
            //}
        }
        void Refresh()
        {
            StaffManager staffManager = new StaffManager();
            grdProductData.ItemsSource = staffManager.DisplayResult();
        }


        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            StaffModel staffModel = new StaffModel();
            staffModel.StaffID = id;
            
            staffModel.StaffName = txtStaffName.Text;
            staffModel.StaffEmail = txtEmail.Text;
            staffModel.StaffMobile = txtStaffMobile.Text;
            staffModel.Qualification = txtqualification.Text;
            staffModel.StaffAddress= txtAddress.Text;
            staffModel.StaffCity= txtCity.Text;
            staffModel.StaffPincode= txtPincode.Text;
            staffModel.StaffUserName = txtUsername.Text;
            staffModel.StaffPassword= pwdUsername.Text;
            staffModel.StaffGender = int.Parse(txtgender.Text);
            StaffManager staffManager=new StaffManager();
            staffManager.UpdateData(staffModel);
            MessageBox.Show("Edited");
            

        }
    }
}
