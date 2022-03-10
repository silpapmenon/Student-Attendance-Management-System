﻿using BusinessLayer;
using EntityLayer.Model;
using StudentAttendanceManagementSystem.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentAttendanceManagementSystem.ViewModels
{
    public class AddDivisionViewModel:BaseViewModel
    {
        public ICommand Submit { get; set; }
        private DivisionModel _divisionModel;
        private List<DivisionModel> _divisionViewList;
        public List<DivisionModel> DivisionViewList { get => _divisionViewList; set => _divisionViewList = value; }

        public DivisionManager divisionManager = new DivisionManager();
        public AddDivisionViewModel(DivisionModel division)
        {
            _divisionModel = division;
            DivisionViewList = divisionManager.DisplayResult();
            Submit = new DivisionSubmit(this);
        }
        private int _divisionID;
        private string _divisionName;
        private int _standardID;
        private int _seat;
        public int DivisionID
        {
            get { return _divisionID; }
            set
            {
                _divisionID = value;
                OnPropertyChanged("DivisionID");
            }
        }
        public int StandardID
        {
            get { return _standardID; }
            set
            {
                _standardID = value;
                OnPropertyChanged("StandardID");
            }
        }
        public string DivisionName
        {
            get { return _divisionName; }
            set
            {
                _divisionName = value;
                OnPropertyChanged("DivisionName");
            }
        }
        public int Seat
        {
            get { return _seat; }
            set
            {
                _seat = value;
                OnPropertyChanged("Seat");
            }
        }
    }
}
