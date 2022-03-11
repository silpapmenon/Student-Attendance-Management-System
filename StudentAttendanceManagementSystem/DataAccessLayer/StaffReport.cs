using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class StaffReport
    {
        public List<StaffModel> GetStaffList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Staff
                         select getdata;

            List<StaffModel> staffModels = new List<StaffModel>();
            foreach (var item in result)
            {
                StaffModel staffModel = new StaffModel();
                staffModel.StaffID = item.StaffID;
                staffModel.StaffName = item.StaffName;
                staffModel.StaffEmail = item.Email;
                staffModel.StaffMobile = item.Mobile;
                staffModel.StaffImage = item.Image;
                staffModel.Qualification = item.Qualification;
                staffModel.StaffAddress = item.Address;
                staffModel.StaffCity = item.City;
                staffModel.StaffPincode = item.Pincode;
                staffModel.StaffGender = item.Gender;

                staffModels.Add(staffModel);
            }
            return staffModels;

        }
        
    }
}
