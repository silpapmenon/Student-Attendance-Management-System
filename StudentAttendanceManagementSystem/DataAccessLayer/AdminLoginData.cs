using EntityLayer.Interface;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdminLoginData : IAdminLogin
    {
        public bool Login(AdminModel adminModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                var query = studentManagementSystemEntities.Admins.Where(x => x.Username == adminModel.Username && x.Password == adminModel.Password);
                if (query.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception oxox)
            {

                throw oxox;
            }
            
        }
    }
}
