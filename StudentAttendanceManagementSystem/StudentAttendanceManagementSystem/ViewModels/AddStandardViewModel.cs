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
    public class AddStandardViewModel : BaseViewModel
    {
        private StandardModel _standardModel;
        private List<StandardModel> _standardViewList;
        public List<StandardModel> StandardViewList { get => _standardViewList; set => _standardViewList = value; }

        public StandardManager standardManager = new StandardManager();
        public AddStandardViewModel(StandardModel standard)
        {
            _standardModel = standard;
            StandardViewList = standardManager.DisplayResult();
            Submit = new StandardSubmit(this);

        }
        private int _standardId;
        private string _standardName;


        public int StandardID
        {
            get { return _standardId; }
            set
            {
                _standardId = value;
                OnPropertyChanged("DivisionID");
            }
        }
        public string StandardName
        {
            get { return _standardName; }
            set
            {
                _standardName = value;
                OnPropertyChanged("StandardName");
            }
        }
        public ICommand Submit { get; set; }
    }
}

