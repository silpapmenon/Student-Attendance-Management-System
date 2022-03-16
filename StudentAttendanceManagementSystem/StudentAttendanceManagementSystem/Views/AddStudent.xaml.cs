using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections;
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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : UserControl
    {
        public int ID;
        public AddStudent()
        {

            InitializeComponent();
            this.DataContext = new AddStudentViewModel();
            //Refresh();
        }

        private void grdProductData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            btnAdd.Content = "Edit";
            txtRollNo.Text = (grdProductData.SelectedItem as StudentModel).RollNo.ToString();
            txtStudentName.Text = (grdProductData.SelectedItem as StudentModel).StudentName;
            dt.Text = (grdProductData.SelectedItem as StudentModel).DOB.ToString();
            txtUsername.Text = (grdProductData.SelectedItem as StudentModel).Studentusername;
            pwdUsername.Password = (grdProductData.SelectedItem as StudentModel).Studentpassword;
            gender.Text = (grdProductData.SelectedItem as StudentModel).GenderName;
            txtEmail.Text = (grdProductData.SelectedItem as StudentModel).StudentEmail;
            txtPincode.Text = (grdProductData.SelectedItem as StudentModel).Studentpincode.ToString();
            txtAddress.Text = (grdProductData.SelectedItem as StudentModel).StudentAddress;
            txtStudentMobile.Text = (grdProductData.SelectedItem as StudentModel).StudentMobile.ToString();
            txtCity.Text = (grdProductData.SelectedItem as StudentModel).StudentCity;
            //gender.Text = (grdProductData.SelectedItem as StudentModel).GenderName;
            div.Text = (grdProductData.SelectedItem as StudentModel).DivisionName;
            standard.Text = (grdProductData.SelectedItem as StudentModel).StandardName;
            Refresh();
        }

        private void grdProductData_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var row_list = GetDataGridRows(grdProductData);
                foreach (DataGridRow single_row in row_list)
                {
                    if (single_row.IsSelected == true)
                    {
                        StudentModel studentModel = new StudentModel();
                        var data = grdProductData.SelectedItem;
                        string id = (grdProductData.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text;
                        txtid.Text = id;
                        //Refresh();

                    }
                }

            }
            catch { }
        }
        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grdProductData)
        {
            var itemsSource = grdProductData.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grdProductData.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }

        
 
        void Refresh()
        {
            StudentManager studentManager = new StudentManager();
            grdProductData.ItemsSource = studentManager.DisplayResult();
        }
       
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdProductData.Items.Count > 0)
                {
                    string StudentID = txtid.Text;
                    if (!string.IsNullOrEmpty(StudentID))
                    {

                    }
                    else
                    {

                    }
                    //string RollNo = txtRollNo.Text;
                    //string StudentName = txtStudentName.Text;
                    //string DOB = dt.Text;
                    //string Studentusername = txtUsername.Text;
                    //string Studentpassword = pwdUsername.Text;
                    //string GenderName = gender.Text;
                    //string StudentEmail = txtEmail.Text;
                    //string Studentpincode = txtPincode.Text;
                    //string StudentAddress = txtAddress.Text;
                    //string StudentMobile = txtStudentMobile.Text;
                    //string StudentCity = txtCity.Text;
                    //string DivisionName = div.Text;
                    //string StandardName = standard.Text;
                    var value = (grdProductData.SelectedItem as StudentModel).StudentID;
                    StudentModel studentModel = new StudentModel();
                    StudentManager studentManager = new StudentManager();
                    studentModel.StudentID = value;
                    studentManager.DeleteStudentDetails(studentModel);
                    MessageBox.Show("Deleted");
                    Refresh();
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

    }
}



