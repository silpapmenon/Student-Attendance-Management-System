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
    /// Interaction logic for AddDivision.xaml
    /// </summary>
    public partial class AddDivision : UserControl
    {
        public int id;
        public AddDivision()
        {
            InitializeComponent();
            Refresh();
        }
        void Refresh()
        {
            DivisionManager divisionManager = new DivisionManager();
            grdDivisionData.ItemsSource = divisionManager.DisplayResult();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DivisionModel divisionModel = new DivisionModel();
            divisionModel.StandardName = StandardName.Text;
            divisionModel.DivisionName = DivisionName.Text;
            divisionModel.Seat = Convert.ToInt32(txtSeat.Text);
            DivisionData addDivisionData = new DivisionData();
            addDivisionData.SaveDivisionData(divisionModel);
            MessageBox.Show("Value Inserted");
            Refresh();
            ClearTextBox();
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DivisionModel divisionModel = new DivisionModel();
            divisionModel.DivisionID = id;
            divisionModel.DivisionName = DivisionName1.Text;
            divisionModel.StandardName = StandardName1.Text;
            divisionModel.Seat = Convert.ToInt32(txtSeatEdit.Text);
            DivisionManager addDivisionBusinessModel = new DivisionManager();
            addDivisionBusinessModel.UpdateData(divisionModel);
            MessageBox.Show("Edited");
            Refresh();
            ClearTextBox();
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            id = (grdDivisionData.SelectedItem as DivisionModel).DivisionID;
            StandardName1.Text = (grdDivisionData.SelectedItem as DivisionModel).StandardName.ToString();
            DivisionName1.Text = (grdDivisionData.SelectedItem as DivisionModel).DivisionName;
            txtSeatEdit.Text = (grdDivisionData.SelectedItem as DivisionModel).Seat.ToString();
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
            StandardName.Text = String.Empty;
            DivisionName.Text = String.Empty;
            txtSeatEdit.Text = String.Empty;
            DivisionName1.Text = String.Empty;
            txtSeat.Text = String.Empty;
            StandardName1.Text = String.Empty;            
        }
    }
}
