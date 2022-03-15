using EntityLayer.Interface;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StaffDetailsData : IStaffDetails
    {
        public List<StaffModel> GetAllDetails(StaffModel staffModel)
        {
            try
            {
                List<StaffModel> stafflist = new List<StaffModel>();
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                var query = from staffs in studentManagementSystemEntities.Staffs
                            where staffs.UserName == staffModel.StaffUserName
                            select staffs;
                foreach (var item in query)
                {
                    StaffModel staffModelinfo = new StaffModel();
                    staffModelinfo.StaffName = item.StaffName;
                    staffModelinfo.StaffPincode = item.Pincode;
                    staffModelinfo.StaffCity = item.City;
                    staffModelinfo.StaffPassword= item.Password;
                    staffModelinfo.Qualification = item.Qualification;
                    staffModelinfo.StaffGender = item.Gender;
                    staffModelinfo.Standard= item.Standard;
                    staffModelinfo.StaffUserName= item.UserName;
                    staffModelinfo.StaffEmail= item.Email;
                    staffModelinfo.StaffMobile= item.Mobile;
                    staffModelinfo.StaffAddress= item.Address;
                    stafflist.Add(staffModelinfo);
                }
                return stafflist;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateStaffData(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities staffs = new StudentManagementSystemEntities();

                var query = from staffinfo in staffs.Staffs
                            where staffinfo.UserName == staffModel.StaffUserName
                            select staffinfo;
                foreach (var item in query)
                {
                    item.StaffName = staffModel.StaffName;
                   // item.Standard = staffModel.Standard;
                    item.Pincode = staffModel.StaffPincode;
                    item.City = staffModel.StaffCity;
                    item.Mobile= staffModel.StaffMobile;
                    item.Email = staffModel.StaffEmail;
                    item.Address= staffModel.StaffAddress;
                    //item.Gender= staffModel.StaffGender;
                    item.Password= staffModel.StaffPassword;
                    //item.Qualification= staffModel.Qualification;
                    item.UserName= staffModel.StaffUserName;

                }
                staffs.SaveChanges();



            }
            catch (Exception ex)

            {
                throw ex;
            }
        }

        public void UpdateStudentData(StaffModel staffModel)
        {
            throw new NotImplementedException();
        }
    }
}
