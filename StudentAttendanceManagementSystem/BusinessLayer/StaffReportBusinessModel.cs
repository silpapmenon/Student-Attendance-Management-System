using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StaffReportBusinessModel
    {
        public List<StaffModel> DisplayResult()
        {
            StaffReport staffReport = new StaffReport();
            return staffReport.GetStaffList();
        }
    }
}
