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
    public class AdminUserLoginBusiness : IAdminLogin
    {
        AdminLoginData adminLoginData = new AdminLoginData();
        public bool Login(AdminModel adminModel)
        {
            return adminLoginData.Login(adminModel);
        }
    }
}
