﻿using EntityLayer.Model;
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
                // staff.StaffID = staffModel.StaffID;
                staff.Standard=staffModel.Standard;
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
                staff.Gender = staffModel.StaffGender;
                staff.RoleID = 2;
                studentManagementSystemEntities.Staffs.Add(staff);
                studentManagementSystemEntities.SaveChanges();
                // MessageBox.Show("Value Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //public List<StaffModel> SaveStaffData()
        //{
        //    StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
        //    var result = from staffObj in studentManagementSystemEntities.Staffs
        //                 join newObj in studentManagementSystemEntities.Genders on staffObj.Gender equals newObj.GenderID
        //                 select staffObj;
        //    List<StaffModel> staffModels = new List<StaffModel>();
        //    foreach (var item in result)
        //    {
        //        StaffModel model = new StaffModel();
        //        model.StaffID = item.StaffID;
        //        model.StaffName=item.StaffName;
        //        model.StaffEmail = item.Email;
        //        model.StaffMobile = item.Mobile;
        //        model.Qualification=item.Qualification;
        //        model.StaffAddress=item.Address;
        //        model.StaffCity=item.City;
        //        model.StaffPincode=item.Pincode;
        //        model.StaffUserName=item.UserName;
        //        model.StaffPassword=item.Password;
        //        model.StaffGender = item.GenderName;
        //        model.RoleID = 3;
        //        staffModels.Add(model);
        //    }
        //    return staffModels;
        //}
        public List<StaffModel> GetStaffList() 
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Staffs
                         select getdata;

            List<StaffModel> staffModels = new List<StaffModel>();
            foreach (var item in result)
            {
                StaffModel staffModel = new StaffModel();              
                //staffModel.StaffID = item.StaffID;
                staffModel.Standard=item.Standard;
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
                staffModel.RoleID = 3;
                staffModels.Add(staffModel);
            }
            return staffModels;

        }
        public void UpdateStaffData(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                var query = from staffObj in studentManagementSystemEntities.Staffs
                            where staffObj.StaffID == staffModel.StaffID
                            select staffObj;
                foreach (var entity in query)
                {
                    entity.StaffID = staffModel.StaffID;
                    entity.StaffName = staffModel.StaffName;
                    entity.Email = staffModel.StaffEmail;
                    entity.Mobile = staffModel.StaffMobile;
                    entity.Image = staffModel.StaffImage;
                    entity.Qualification = staffModel.Qualification;
                    entity.Address = staffModel.StaffAddress;
                    entity.City = staffModel.StaffCity;
                    entity.Pincode = staffModel.StaffPincode;
                    entity.UserName = staffModel.StaffUserName;
                    entity.Password = staffModel.StaffPassword;
                    entity.Gender = staffModel.StaffGender;
                    entity.RoleID = 3;

                }
                studentManagementSystemEntities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteData(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities entities = new StudentManagementSystemEntities();
                var result = from staffObj in entities.Staffs
                             where staffObj.StaffID==staffModel.StaffID
                             select staffObj;
                foreach (var entity in result)
                {
                    entities.Staffs.Remove(entity);
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

