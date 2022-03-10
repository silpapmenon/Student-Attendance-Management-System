using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.Command
{
    public class DivisionSubmit:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddDivisionViewModel addDivisionViewModel { get; set; } 
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
            DivisionModel division = new DivisionModel();
            division.StandardID = addDivisionViewModel.StandardID;
            division.DivisionName = addDivisionViewModel.DivisionName;
            
            DivisionManager divisionManager = new DivisionManager();
            divisionManager.SaveDivisionDetails(division);

        }
    }
}
