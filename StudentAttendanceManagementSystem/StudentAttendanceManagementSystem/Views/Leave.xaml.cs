using BusinessLayer;
using DataAccessLayer;
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
    /// Interaction logic for Leave.xaml
    /// </summary>
    public partial class Leave : UserControl
    {
        public Leave()
        {
            InitializeComponent();
        }
        void ClearTextBox()
        {
            txtrollno.Text = String.Empty;
            txtDivision.Text = String.Empty;
            txtmsg.Text = String.Empty;
            txtnumdays.Text = String.Empty;
            txtstandard.Text = String.Empty;
            dt.Text = String.Empty;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LeaveManager leaveManager = new LeaveManager();
            LeaveModel leaveModel = new LeaveModel();
            int RollNo =Convert.ToInt32(txtrollno.Text);
            string Message = txtmsg.Text;
            int NumDays = Convert.ToInt32(txtnumdays.Text);
            string StandardName = txtstandard.Text;
            string DivisionName = txtDivision.Text;
            DateTime Date = DateTime.Now;
            leaveModel.Date = Convert.ToDateTime(dt.SelectedDate);
            leaveModel.RollNo=RollNo;
            leaveModel.NumDays=NumDays;
            leaveModel.Division=DivisionName;
            leaveModel.Message=Message;
            leaveModel.Standard=StandardName;
            leaveManager.SaveLeaveDetails(leaveModel);
            MessageBox.Show("Value Inserted");
            ClearTextBox();


        }
        void Refresh()
        {
            LeaveManager leaveManager = new LeaveManager();
           // grdLeaveData.ItemsSource = grdLeaveData.DisplayResult();
        }
    }
}
