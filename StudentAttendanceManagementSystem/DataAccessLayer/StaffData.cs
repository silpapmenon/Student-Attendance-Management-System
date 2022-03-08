using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StaffData
    {
        public void SaveStaffData(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                Staff staff = new Staff();
                staff.StaffName = staffModel.StaffName;
                staff.Email = staffModel.StaffEmail;
                staff.Mobile = staffModel.StaffMobile;
                staff.Image = staffModel.StaffImage;
                staff.Qualification = staffModel.Qualification;
                staff.Address = staffModel.StaffAddress;
                staff.City = staffModel.StaffCity;
                staff.Pincode = staffModel.StaffPincode;
                staff.UserName = staffModel.StaffUserName;
                staff.Password = staffModel.StaffPassword;
                staff.Gender = 2;
                staff.RoleID = 2;
                studentManagementSystemEntities.Staff.Add(staff);
                studentManagementSystemEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<StaffModel> GetStaffList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Staff
                         select getdata;

            List<StaffModel> staffModels = new List<StaffModel>();
            foreach (var item in result)
            {
                StaffModel staffModel = new StaffModel();              
                staffModel.StaffName = item.StaffName;
                staffModel.StaffEmail = item.Email;
                staffModel.StaffMobile = item.Mobile;
                staffModel.StaffImage = item.Image;
                staffModel.Qualification = item.Qualification;
                staffModel.StaffAddress = item.Address;
                staffModel.StaffCity = item.City;
                staffModel.StaffPincode = item.Pincode;
                staffModel.StaffUserName = item.UserName;
                staffModel.StaffPassword = item.Password;
                staffModel.StaffGender = item.Gender;
                staffModel.RoleID = item.RoleID;
                staffModels.Add(staffModel);
            }
            return staffModels;

        }
        public void UpdateData(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities entities = new StudentManagementSystemEntities();
                var result = from staffObj in entities.Staff
                             where staffObj.StaffID.Equals(staffModel.StaffID)
                             select staffObj;
                foreach (var entity in result)
                {
                    entities.Staff.Remove(entity);
                }
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
