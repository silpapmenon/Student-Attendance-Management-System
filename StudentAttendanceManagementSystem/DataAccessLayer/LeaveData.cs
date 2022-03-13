using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LeaveData
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
                //leaveModel.StudentID=item.StudentID;
                leaveModel.RollNo=item.RollNo;
                leaveModel.Standard = item.StandardName;
                leaveModel.Division = item.DivisionName;
                leaveModel.Message = item.Message;
                leaveModel.NumDays = item.NumDays;
                leaveModel.Date=item.Date;
                
               // leaveModel.Date = (DateTime)item.EndDate;
                leaveModels.Add(leaveModel);
            }
            return leaveModels;

        }
        public void SaveLeaveData(LeaveModel leaveModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                Leave leave = new Leave();
                leave.LeaveID = leaveModel.LeaveID;
                leave.RollNo = leaveModel.RollNo;
                leave.Message=leaveModel.Message;
                leave.NumDays = leaveModel.NumDays;
                leave.Date=leaveModel.Date;
                leave.StandardName = leaveModel.Standard;
                leave.DivisionName = leaveModel.Division;

                studentManagementSystemEntities.Leaves.Add(leave);
                studentManagementSystemEntities.SaveChanges();
                // MessageBox.Show("Value Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
