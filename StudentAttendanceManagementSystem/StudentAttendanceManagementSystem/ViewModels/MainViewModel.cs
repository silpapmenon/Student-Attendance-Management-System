using StudentAttendanceManagementSystem.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedView = new HomeViewModel();

        public BaseViewModel SelectedView
        {
            get { return _selectedView; }
            set { _selectedView = value; OnPropertyChanged(nameof(SelectedView)); }
        }
        public ICommand RedirectViewCommand { get; set; }
        public MainViewModel()
        {
            RedirectViewCommand = new RedirectViewCommand(this);
        }
    }
}
