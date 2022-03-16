using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StaffUserLoginData : IStaffUserLogin
    {
        public bool GetAll(StaffModel staffModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                var query = studentManagementSystemEntities.Staffs.Where(x => x.UserName == staffModel.StaffUserName && x.Password == staffModel.StaffPassword);
                if (query.Count() > 0)
                    return true;
                else 
                    return false;
            }
            catch (Exception xoox)
            {

                throw xoox;
            }
        }
    }
}
