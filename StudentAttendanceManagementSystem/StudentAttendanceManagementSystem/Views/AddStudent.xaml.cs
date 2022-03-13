using BusinessLayer;
using EntityLayer.Model;
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
            Refresh();
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
            pwdUsername.Text = (grdProductData.SelectedItem as StudentModel).Studentpassword;
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {           
            //btnAdd.Content = "Edit";
            Refresh();
            if (btnAdd.Content == "Edit")
            {
                string StudentID = txtid.Text;
                string RollNo = txtRollNo.Text;
                string StudentName = txtStudentName.Text;
                string DOB = dt.Text;
                string Studentusername = txtUsername.Text;
                string Studentpassword = pwdUsername.Text;
                string GenderName = gender.Text;
                string StudentEmail = txtEmail.Text;
                string Studentpincode = txtPincode.Text;
                string StudentAddress = txtAddress.Text;
                string StudentMobile = txtStudentMobile.Text;
                string StudentCity = txtCity.Text;
                string DivisionName = div.Text;
                string StandardName = standard.Text;
                if (!string.IsNullOrEmpty(StudentID) && !string.IsNullOrEmpty(RollNo) && !string.IsNullOrEmpty(StudentName)
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
                            if (!int.TryParse(StudentMobile, out _))
                            {
                                MessageBox.Show("Mobile Number should be number");
                            }
                            else
                            {
                                if (StudentMobile.Count() == 10 )
                                {
                                    if (!isValidEmail(StudentEmail))
                                    {
                                        MessageBox.Show("Invalid Email ID");
                                    }
                                    else
                                    {
                                        StudentModel studentModel = new StudentModel();
                                        studentModel.StudentID = Convert.ToInt32(txtid.Text);
                                        studentModel.RollNo = Convert.ToInt32(txtRollNo.Text);
                                        studentModel.StudentName = txtStudentName.Text;
                                        studentModel.DOB = Convert.ToDateTime(dt.Text);
                                        studentModel.Studentusername = txtUsername.Text;
                                        studentModel.Studentpassword = pwdUsername.Text;
                                        studentModel.GenderName = gender.Text;
                                        studentModel.StudentEmail = txtEmail.Text;
                                        studentModel.Studentpincode = Convert.ToInt32(txtPincode.Text);
                                        studentModel.StudentAddress = txtAddress.Text;
                                        studentModel.StudentMobile = txtStudentMobile.Text;
                                        studentModel.StudentCity = txtCity.Text;
                                        //studentModel.Gender = gender.Text;
                                        studentModel.DivisionName = div.Text;
                                        studentModel.StandardName = standard.Text;
                                        StudentManager studentManager = new StudentManager();
                                        studentManager.UpdateData(studentModel);
                                        // MessageBox.Show("Student Details Edited");
                                        Refresh();
                                        txtid.Text = String.Empty;

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
            else
            {
                //string StudentID = txtid.Text;
                string RollNo = txtRollNo.Text;
                string StudentName = txtStudentName.Text;
                string DOB = dt.Text;
                string Studentusername = txtUsername.Text;
                string Studentpassword = pwdUsername.Text;
                string GenderName = gender.Text;
                string StudentEmail = txtEmail.Text;
                string Studentpincode = txtPincode.Text;
                string StudentAddress = txtAddress.Text;
                string StudentMobile = txtStudentMobile.Text;
                string StudentCity = txtCity.Text;
                string DivisionName = div.Text;
                string StandardName = standard.Text;
                if (  !string.IsNullOrEmpty(RollNo) && !string.IsNullOrEmpty(StudentName)
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
                            if (!int.TryParse(StudentMobile, out _))
                            {
                                MessageBox.Show("Mobile Number should be number");
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
                                        StudentModel studentModels = new StudentModel();                                      
                                        studentModels.RollNo = Convert.ToInt32(txtRollNo.Text);
                                        studentModels.StudentName = txtStudentName.Text;
                                        studentModels.DOB = Convert.ToDateTime(dt.Text);
                                        studentModels.Studentusername = txtUsername.Text;
                                        studentModels.Studentpassword = pwdUsername.Text;
                                        studentModels.GenderName = gender.Text;
                                        studentModels.StudentEmail = txtEmail.Text;
                                        studentModels.Studentpincode = Convert.ToInt32(txtPincode.Text);
                                        studentModels.StudentAddress = txtAddress.Text;
                                        studentModels.StudentMobile = txtStudentMobile.Text;
                                        studentModels.StudentCity = txtCity.Text;
                                        //studentModel.Gender = gender.Text;
                                        studentModels.DivisionName = div.Text;
                                        studentModels.StandardName = standard.Text;
                                        StudentManager studentManagers = new StudentManager();
                                        studentManagers.SaveStudentDetails(studentModels);
                                        // MessageBox.Show("Student Details Edited");
                                        Refresh();
                                        txtid.Text = String.Empty;
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
void Refresh()
        {
            StudentManager studentManager = new StudentManager();
            grdProductData.ItemsSource = studentManager.DisplayResult();
        }
        void ClearTextBox() 
        {
            txtRollNo.Text = String.Empty;
            txtStudentName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtStudentMobile.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtPincode.Text = String.Empty;
            txtUsername.Text = String.Empty;
            pwdUsername.Text = String.Empty;
            div.Text = String.Empty;
            gender.Text = String.Empty;
            standard.Text = String.Empty;
            dt.Text = String.Empty;
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



