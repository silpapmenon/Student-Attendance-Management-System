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
    /// Interaction logic for AddStandard.xaml
    /// </summary>
    public partial class AddStandard : UserControl
    {
        public int id;
        public AddStandard()
        {
            InitializeComponent();
        }
        void Refresh()
        {
            StandardManager standardManager = new StandardManager();
            grdStandardData.ItemsSource = standardManager.DisplayResult();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            id = (grdStandardData.SelectedItem as StandardModel).StandardID;
            txtID.Text = (grdStandardData.SelectedItem as StandardModel).StandardID.ToString();
            txtStandardName.Text = (grdStandardData.SelectedItem as StandardModel).StandardName.ToString();
            
            Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grdStandardData.Items.Count > 0)
                {
                    var value = (grdStandardData.SelectedItem as StandardModel).StandardID;
                    StandardModel standardModel = new StandardModel();
                    StandardManager standardManager = new StandardManager();
                    standardModel.StandardID = value;
                    standardManager.DeleteStandardDetails(standardModel);
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
    

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StandardModel standardModel = new StandardModel();
            //standardModel.StandardID = Convert.ToInt32(txtID.Text);
            standardModel.StandardName = txtStandardName.Text;
            StanadardData stanadardData = new StanadardData();
            stanadardData.SaveStandardData(standardModel);
            MessageBox.Show("Value Inserted");




        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            StandardModel standardModel = new StandardModel();
            standardModel.StandardID = id;

            standardModel.StandardName = txtStandardName.Text;
            
            StandardManager standardManager = new StandardManager();
            standardManager.UpdateStandardData(standardModel);
            MessageBox.Show("Edited");
        }
    }
}
