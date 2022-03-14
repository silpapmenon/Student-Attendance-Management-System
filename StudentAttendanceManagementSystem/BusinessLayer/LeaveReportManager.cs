using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LeaveReportManager
    {
        public List<LeaveModel> DisplayResult()
        {
            LeaveReportData leaveData = new LeaveReportData();
            return leaveData.GetLeaveList();
        }
    }
}
