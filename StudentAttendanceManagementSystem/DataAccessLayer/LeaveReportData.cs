using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LeaveReportData
    {
        public List<LeaveModel> GetLeaveList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Leaves
                         select getdata;

            List<LeaveModel> leaveModels = new List<LeaveModel>();
            foreach (var item in result)
            {
                LeaveModel leaveModel = new LeaveModel();
                leaveModel.LeaveID = item.LeaveID;
                leaveModel.RollNo = item.RollNo;
                leaveModel.Message = item.Message;
                leaveModel.NumDays = item.NumDays;
                leaveModel.Date = item.Date;
                leaveModel.Standard = item.StandardName;
                leaveModel.Division = item.DivisionName;

                leaveModels.Add(leaveModel);
            }
            return leaveModels;

        }
    }
}
