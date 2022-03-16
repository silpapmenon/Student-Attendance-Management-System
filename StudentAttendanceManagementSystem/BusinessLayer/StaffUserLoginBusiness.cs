using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   
    public class StaffUserLoginBusiness : IStaffUserLogin
    {
        StaffUserLoginData staffUserLoginData = new StaffUserLoginData();

        public bool GetAll(StaffModel staffModel)
        {
            return staffUserLoginData.GetAll(staffModel);
        }
    }
}
