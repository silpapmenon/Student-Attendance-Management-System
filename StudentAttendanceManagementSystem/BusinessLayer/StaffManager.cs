using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StaffManager
    {
        public void SaveStaffDetails(StaffModel staffModel)
        {
            StaffData staffData = new StaffData();
            staffData.SaveStaffData(staffModel);
        }
        public List<StaffModel> DisplayResult()
        {
            StaffData staffData = new StaffData();
            return staffData.GetStaffList();
        }
        public void UpdateData(StaffModel staffModel)
        {
            StaffData staffData = new StaffData();
            staffData.UpdateStaffData(staffModel);
        }
        //public void DeleteStaffDetails(StaffModel staffModel)
        //{
        //    StaffData staffData = new StaffData();
        //    staffData.DeleteData(staffModel);
        //}
    }
}

