using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LeaveBusinessModel
    {
        public List<LeaveModel> DisplayResult()
        {
            LeaveData leaveData = new LeaveData();
            return leaveData.GetLeaveList();
        }
    }
}
