using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LeaveManager
    {
        public List<LeaveModel> DisplayResult()
        {
            LeaveData leaveData = new LeaveData();
            return leaveData.GetLeaveList();
        }
        public void SaveLeaveDetails(LeaveModel leaveModel)
        {
            LeaveData leaveData = new LeaveData();
            leaveData.SaveLeaveData(leaveModel);
        }

    }
}
