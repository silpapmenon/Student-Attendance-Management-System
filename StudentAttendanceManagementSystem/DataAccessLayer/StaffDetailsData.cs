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
                    stafflist.Add(staffModelinfo);
                }
                return stafflist;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateStudentData(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities students = new StudentManagementSystemEntities();

                var query = from staffinfo in students.Staffs
                            where staffinfo.UserName == staffModel.StaffUserName
                            select staffinfo;
                foreach (var item in query)
                {
                    item.StaffName = item.StaffName;

                }
                students.SaveChanges();



            }
            catch (Exception ex)

            {
                throw ex;
            }
        }
    }
}
