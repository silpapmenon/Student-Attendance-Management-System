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
            divisionModel.StandardID = Convert.ToInt32(StandardID.Text);
            divisionModel.DivisionName = txtDivisionName.Text;
            divisionModel.Seat = Convert.ToInt32(txtSeat.Text);
            DivisionData addDivisionData = new DivisionData();
            addDivisionData.SaveDivisionData(divisionModel);
            MessageBox.Show("Value Inserted");
            Refresh();
            //    ClearTextBox();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DivisionModel divisionModel = new DivisionModel();
            divisionModel.StandardID = id;
            divisionModel.DivisionName = txtDivisionName1.Text;
            divisionModel.Seat = Convert.ToInt32(txtSeatEdit.Text);
            DivisionManager addDivisionBusinessModel = new DivisionManager();
            addDivisionBusinessModel.UpdateData(divisionModel);
            MessageBox.Show("Edited");
            Refresh();
            //    ClearTextBox();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            id = (grdDivisionData.SelectedItem as DivisionModel).StandardID;
            StandardID1.Text = (grdDivisionData.SelectedItem as DivisionModel).StandardID.ToString();
            txtDivisionName1.Text = (grdDivisionData.SelectedItem as DivisionModel).DivisionName;
            txtSeatEdit.Text = (grdDivisionData.SelectedItem as DivisionModel).Seat.ToString();
            Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                if (grdDivisionData.Items.Count > 0)
                {
                    var value = (grdDivisionData.SelectedItem as DivisionModel).StandardID;
                    DivisionModel divisionModel = new DivisionModel();
                    DivisionManager division = new DivisionManager();
                    divisionModel.StandardID = value;
                    division.DeleteDivisionDetails(divisionModel);
                    MessageBox.Show("Division Deleted :" + divisionModel.StandardID);
                    Refresh();
                    //ClearTextBox();
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



        //void Refresh()
        //{
        //    AddDivisionBusinessModel addDivisionBusinessModel = new AddDivisionBusinessModel();
        //    grdDivisionData.ItemsSource = addDivisionBusinessModel.GetData();
        //}
        //void ClearTextBox()
        //{
        //    txtStandardID.Text = String.Empty;
        //    txtDivisionName.Text = String.Empty;
        //    txtSeats.Text = String.Empty;
        //}
    }
}
