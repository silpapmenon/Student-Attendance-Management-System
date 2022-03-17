using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class DivisionSubmit:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddDivisionViewModel addDivisionViewModel { get; set; }
        public object Messagebox { get; private set; }

        public DivisionSubmit(AddDivisionViewModel addDivisionView)
        {
            addDivisionViewModel = addDivisionView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Add")
            {
                DivisionModel division = new DivisionModel();
                division.StandardName = addDivisionViewModel.StandardName;
                division.DivisionName = addDivisionViewModel.DivisionName;
                division.Seat = addDivisionViewModel.Seat;
                DivisionManager divisionManager = new DivisionManager();
                divisionManager.SaveDivisionDetails(division);
                MessageBox.Show("Added Succesfully");

            }
            else if (parameter.ToString() == "Edit")
            {
                DivisionModel division = new DivisionModel();
                division.DivisionID = addDivisionViewModel.DivisionID;
                division.StandardName = addDivisionViewModel.StandardName;
                division.DivisionName = addDivisionViewModel.DivisionName;
                division.Seat = addDivisionViewModel.Seat;
                DivisionManager divisionManager = new DivisionManager();
                divisionManager.UpdateData(division);
                MessageBox.Show("Updated Succesfully");
            }
            

        }
    }
}
