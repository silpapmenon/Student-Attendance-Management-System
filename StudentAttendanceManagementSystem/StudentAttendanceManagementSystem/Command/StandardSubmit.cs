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
    public class StandardSubmit : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddStandardViewModel addStandardViewModel { get; set; }
        public StandardSubmit(AddStandardViewModel addStandardView)
        {
            addStandardViewModel = addStandardView;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StandardModel standard = new StandardModel();
            standard.StandardID = addStandardViewModel.StandardID;
            standard.StandardName = addStandardViewModel.StandardName;
            StandardManager standardManager = new StandardManager();
            standardManager.SaveStandardDetails(standard);
        }
    }
}
