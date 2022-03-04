using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class RolesModel
    {
        private int _roleID;
        private string _roleName;
        public int RoleID
        { get => _roleID; set => _roleID = value; }
        public string RoleName
        { get => _roleName; set => _roleName = value; }
    }
}
