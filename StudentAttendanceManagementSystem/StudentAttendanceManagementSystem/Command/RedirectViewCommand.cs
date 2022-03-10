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
    public class RedirectViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel model;
        public RedirectViewCommand(MainViewModel viewModel)
        {
            this.model = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "ABOUT US")
            {
                model.SelectedView = new AboutUsViewModel();
            }
            else if (parameter.ToString() == "LOGIN")
            {
                model.SelectedView = new LoginViewModel();
            }
            else if (parameter.ToString() == "MISSION AND VISION")
            {
                model.SelectedView = new MissionandVisionViewModel();
            }
            else if (parameter.ToString() == "OUR PATRONS")
            {
                model.SelectedView = new OurPatronsViewModel();
            }
            else if (parameter.ToString() == "STANDARDS")
            {
                model.SelectedView = new StandardsViewModel();
            }
            //else if (parameter.ToString() == "ADD STAFF")
            //{
            //    StaffModel staffModel = new StaffModel();
            //    model.SelectedView = new AddStaffViewModel(staffModel);
            //}
            else if (parameter.ToString() == "ADMIN PANEL")
            {
                model.SelectedView = new AdminPanelViewModel();
            }
            else if (parameter.ToString() == "ADD STUDENT")
            {
                StudentModel studentModel = new StudentModel();
                model.SelectedView = new AddStudentViewModel(studentModel);

            }
            else if (parameter.ToString() == "CONTACT US")
            {
                model.SelectedView = new ContactUsViewModel();
            }
            else if (parameter.ToString() == "HOME")
            {
                model.SelectedView = new HomeViewModel();
            }
            else if (parameter.ToString() == "STUDENT REPORT")
            {
                StudentModel studentModel=new StudentModel();
                model.SelectedView = new StudentReportViewModel(studentModel);
            }
            else if (parameter.ToString() == "STAFF REPORT")
            {
                StaffModel staffModel = new StaffModel();
                model.SelectedView = new StaffReportViewModel(staffModel);
            }
            else if (parameter.ToString() == "ADD STANDARDS")
            {
                StandardModel standardModel = new StandardModel();
                model.SelectedView = new AddStandardViewModel();
            }
            else if (parameter.ToString() == "ATTENDANCE")
            {

                AttendanceModel attendanceModel = new AttendanceModel();
                model.SelectedView = new AttendanceViewModel(attendanceModel);
            }


        }

    }
}
