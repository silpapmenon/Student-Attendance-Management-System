using BusinessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class AttendanceViewModel : BaseViewModel
    {
        private ObservableCollection<StandardModel> _studentStandard;
        public ObservableCollection<StandardModel> StudentStandard
        {
            get { return _studentStandard; }
            set
            {
                if (_studentStandard == value) return;
                _studentStandard = value;

            }
        }
        private ObservableCollection<DivisionModel> _studentDivision;
        public ObservableCollection<DivisionModel> StudentDivision
        {
            get { return _studentDivision; }
            set
            {
                if (_studentDivision == value) return;
                _studentDivision = value;

            }
        }

        AttendanceBusinessModel attendance = new AttendanceBusinessModel();
        public AttendanceViewModel(AttendanceModel attendanceModel)
        {
            StudentStandard = new ObservableCollection<StandardModel>();
            StandardModel standardModel = new StandardModel();
            var querry = attendance.standard(standardModel);
            foreach (var item in querry)
            {
                StandardModel standardModel2 = new StandardModel();
                standardModel2.StandardName = item.StandardName;
                StudentStandard.Add(standardModel2);
            }
            StudentDivision = new ObservableCollection<DivisionModel>();
            DivisionModel divisionModel = new DivisionModel();
            var querry1 = attendance.division(divisionModel);
            foreach (var item in querry1)
            {
                DivisionModel divisionModel2 = new DivisionModel();
                divisionModel2.DivisionName = item.DivisionName;
                StudentDivision.Add(divisionModel2);
            }
        }
       
       
    }
}
