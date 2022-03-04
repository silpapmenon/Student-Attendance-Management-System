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
    /// Interaction logic for StudentReport.xaml
    /// </summary>
    public partial class StudentReport : UserControl
    {
        public StudentReport()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdStudentReport.Items.Count > 0)
                {
                    var value = (grdStudentReport.SelectedItem as StudentModel).RollNo;
                    StudentModel studentModel = new StudentModel();
                    StudentManager student = new StudentManager();
                    studentModel.RollNo = value;
                    student.DeleteStudentDetails(studentModel);
                    MessageBox.Show("Student Deleted :" + studentModel.RollNo);                   
                }
                else
                {
                    MessageBox.Show("No Product available for Delete:??");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       

        private void grdStudentReport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
