using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
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
    /// Interaction logic for AddDivision.xaml
    /// </summary>
    public partial class AddDivision : UserControl
    {
       
        public AddDivision()
        {
            InitializeComponent();
            Refresh();
            DataContext = new AddDivisionViewModel();
        }
        void Refresh()
        {
            DivisionManager divisionManager = new DivisionManager();
            grdDivisionData.ItemsSource = divisionManager.DisplayResult();
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            txtid.Text = (grdDivisionData.SelectedItem as DivisionModel).DivisionID.ToString();
            txtStandardName.Text = (grdDivisionData.SelectedItem as DivisionModel).StandardName;
            txtDivisionName.Text = (grdDivisionData.SelectedItem as DivisionModel).DivisionName;
            txtSeat.Text = (grdDivisionData.SelectedItem as DivisionModel).Seat.ToString();
            Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdDivisionData.Items.Count > 0)
                {
                    var value = (grdDivisionData.SelectedItem as DivisionModel).DivisionID;
                    DivisionModel divisionModel = new DivisionModel();
                    DivisionManager division = new DivisionManager();
                    divisionModel.DivisionID = value;
                    division.DeleteDivisionDetails(divisionModel);
                    MessageBox.Show("Division Deleted :" + divisionModel.DivisionID);
                    Refresh();
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("No Division available for Delete:??");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void ClearTextBox()
        {
            txtStandardName.Text = String.Empty;
            txtDivisionName.Text = String.Empty;
            txtSeat.Text = String.Empty;

        }
    }
}

