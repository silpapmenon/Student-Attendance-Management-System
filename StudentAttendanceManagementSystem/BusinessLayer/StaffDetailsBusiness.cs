using DataAccessLayer;
using EntityLayer.Interface;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StaffDetailsBusiness : IStaffDetails
    {
        StaffDetailsData staffDetailsData = new StaffDetailsData();

        public List<StaffModel> GetAllDetails(StaffModel staffModel)
        {
            return staffDetailsData.GetAllDetails(staffModel);
        }

        public void UpdateStaffData(StaffModel staffModel)
        {
            staffDetailsData.UpdateStaffData(staffModel);
        }

        public void UpdateStudentData(StaffModel staffModel)
        {
            throw new NotImplementedException();
        }
    }
}
